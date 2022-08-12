using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace Fishes_SOT_parser
{
    public static class Parser
    {
        public static void Start(string url)
        {
            string[] prices = GetPrices(url);

            foreach(string pr in prices)
            {
                Console.WriteLine(pr);
            }
        }

        private static string[] GetPrices(string url)
        {
            string htmlcode = GetHtml(url);
            var tables = GetTables(htmlcode);
            List<string> prices = new();
            foreach (HtmlNode table in tables)
            {
                prices.Add(GetPricesFromTable(table));
            }
            return prices.ToArray();
        }

        private static string GetHtml(string url)
        {
            string htmlCode = "";

            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }
            return htmlCode;
        }

        private static HtmlNodeCollection GetTables(string html)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            htmlSnippet.LoadHtml(html);

            var tables = htmlSnippet.DocumentNode.SelectNodes("//table[@class='wikitable']");
            return tables;
        }

        private static string GetPricesFromTable(HtmlNode table)
        {
            StringBuilder b = new();
            HtmlDocument htmlSnippet = new HtmlDocument();
            string a = table.InnerHtml;
            htmlSnippet.LoadHtml(a);
            var nodes = htmlSnippet.DocumentNode.SelectNodes("//tr/td");
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    string? value = TryParse(node.InnerText);
                    if (value != null)
                        b.Append(value + ' ');
                }
            }
            return b.ToString();
        }

        private static string? TryParse(string str)
        {
            string? value;
            value = TryParsePrice(str);
            if (value != null)
                return value;
            value = TryParseTitle(str);
            if (value != null)
                return value;
            return null;
        }

        private static string? TryParseTitle(string str)
        {
            //catch title and type lines
            Regex regex = new Regex(@"^\w+\s\w+$");
            Match res = regex.Match(str);

            if (string.IsNullOrEmpty(res.Value))
                return null;

            //is it title or type
            regex = new Regex(@"^\w+\svariant$");
            Match match = regex.Match(str);

            if (string.IsNullOrEmpty(match.Value))
                return ")\n.BuildFish(\"" + res.Value + "\",\n";

            return "\"" + match.Value + "\",\nnew Price(";
        }

        private static string? TryParsePrice(string str)
        {
            //catch price lines
            Regex regex = new Regex(@"^[,0-9]+\&\#160;$");
            Match match = regex.Match(str);

            if (string.IsNullOrEmpty( match.Value))
                return null;

            //catch only price in line
            regex = new Regex(@"^([,0-9])+");
            match = regex.Match(match.Value);

            if (string.IsNullOrEmpty(match.Value))
                return null;
            return match.Value.Replace(',', '_') + ", ";
        }
    }
}
