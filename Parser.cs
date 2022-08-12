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
        /// <summary>
        /// public start function that starts parsing
        /// </summary>
        /// <param name="url">url of wiki</param>
        public static void Start(string url)
        {
            Fish[] fishes = GetFishes(url);

            foreach(Fish fish in fishes)
            {
                Console.WriteLine(fish.ToBuilderString());
            }
        }

        /// <summary>
        /// gets fishes from site
        /// </summary>
        /// <param name="url">url of site</param>
        /// <returns>returns list of fishes</returns>
        private static Fish[] GetFishes(string url)
        {
            string htmlcode = GetHtml(url);
            var tables = GetTables(htmlcode);
            List<Fish> prices = new();
            foreach (HtmlNode table in tables)
            {
                var res = GetFishesFromTable(table);
                if(res != null)
                    prices.AddRange(res.ToList());
            }
            return prices.ToArray();
        }

        /// <summary>
        /// gets html string of page
        /// </summary>
        /// <param name="url">url of page</param>
        /// <returns>string html code</returns>
        private static string GetHtml(string url)
        {
            string htmlCode = "";

            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }
            return htmlCode;
        }

        /// <summary>
        /// gets all tables with fish prices from site
        /// </summary>
        /// <param name="html">html code</param>
        /// <returns>list of html nodes with pages inside</returns>
        private static HtmlNodeCollection GetTables(string html)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            htmlSnippet.LoadHtml(html);

            var tables = htmlSnippet.DocumentNode.SelectNodes("//table[@class='wikitable']");
            return tables;
        }

        /// <summary>
        /// extracts info about all fishes inside from table
        /// </summary>
        /// <param name="table">html node of table</param>
        /// <returns>list of fishes from table</returns>
        private static Fish[] GetFishesFromTable(HtmlNode table)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            htmlSnippet.LoadHtml(table.InnerHtml);
            var nodes = htmlSnippet.DocumentNode.SelectNodes("//tr/td");
            List<Fish> fishes = new();
            if (nodes != null)
            {
                Fish fish = new Fish();
                foreach (var node in nodes)
                {
                    TryParse(node.InnerText, fish);
                    if (!fish.IsDataEmpty())
                    {
                        fish.BuildPath();
                        fishes.Add(fish);
                        fish = new Fish();
                    }
                }
            }
            return fishes.ToArray();
        }

        /// <summary>
        /// tries to parse found info and transform it into fish property
        /// </summary>
        /// <param name="str">info to parse</param>
        /// <param name="fish">fish, whose property we will change</param>
        private static void TryParse(string str, Fish fish)
        {
            string? value;
            value = TryParsePrice(str);
            if (value != null)
            {
                fish.Prices.Add(Int32.Parse(value));
                return;
            }

            value = TryParseType(str);
            if (value != null)
            {
                fish.Type = value;
                return;
            }

            value = TryParseTitle(str);
            if (value != null)
            {
                fish.Name = value;
                return;
            }
        }

        /// <summary>
        /// tries to parse given info to a fish type using regular expressions
        /// </summary>
        /// <param name="str">given string info</param>
        /// <returns>string result if success, else null</returns>
        private static string? TryParseType(string str)
        {
            //catch title and type lines
            Regex regex = new Regex(@"^\w+\s\w+$");
            Match res = regex.Match(str);

            if (string.IsNullOrEmpty(res.Value))
                return null;

            //is it title or type
            regex = new Regex(@"^\w+\svariant$");
            res = regex.Match(str);

            if (string.IsNullOrEmpty(res.Value))
                return null;
            return res.Value;
        }

        /// <summary>
        /// tries to parse given info to a fish title using regular expressions
        /// </summary>
        /// <param name="str">given string info</param>
        /// <returns>string result if success, else null</returns>
        private static string? TryParseTitle(string str)
        {
            //catch title and type lines
            Regex regex = new Regex(@"^\w+\s\w+$");
            Match res = regex.Match(str);

            if (string.IsNullOrEmpty(res.Value))
                return null;

            return res.Value;
        }

        /// <summary>
        /// tries to parse given info to a price using regular expressions
        /// </summary>
        /// <param name="str">given string info</param>
        /// <returns>string result if success, else null</returns>
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
            return match.Value.Replace(",", String.Empty);
        }
    }
}
