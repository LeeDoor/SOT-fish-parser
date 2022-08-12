using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishes_SOT_parser
{
    public class Fish
    {
        // fish properties
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public List<int> Prices { get; set; }

        /// <summary>
        /// constructors
        /// </summary>
        public Fish()
        {
            Name = "";
            Type = "";
            Path = "";
            Prices = new List<int>();
        }
        public Fish(string name, string type, string path, List<int> price)
        {
            Name = name;
            Type = type;
            Path = path;
            Prices = price;
        }

        /// <summary>
        /// is this fish info not fully filled in
        /// </summary>
        /// <returns>true if one of property is empty</returns>
        public bool IsDataEmpty()
        {
            return
                (string.IsNullOrEmpty(Name) ||
                Prices.Count != 8);
        }

        /// <summary>
        /// creates path to image using name
        /// </summary>
        public void BuildPath()
        {
            var words = Name.Split();
            Path = "\"images\\\\fishes\\\\" //bolshe sleshey bogu sleshey
                + char.ToUpper(words[0][0]) 
                + words[0].Substring(1)
                + "_"
                + char.ToUpper(words[1][0])
                + words[1].Substring(1)
                + ".png\"";
        }

        /// <summary>
        /// removes extra price info from list
        /// </summary>
        public void ModifyPrices()
        {
            List<int> prices = new();
            prices.Add(Prices[0]);
            prices.Add(Prices[1]);
            prices.Add(Prices[4]);
            prices.Add(Prices[5]);
            Prices = prices;
        }

        /// <summary>
        /// debug ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} {Type} {Path} ");
            foreach (int price in Prices)
            {
                sb.Append($"{price} ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// returns string, which i can use in my project to create fishes
        /// </summary>
        /// <returns></returns>
        public string ToBuilderString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($".BuildFish(\n" + 
                $"\"{Name}\",\n" +
                $"{Path},\n" +
                $"\"{Type}\",\n" +
                $"new Location(),\n" +
                $"new Price(");
            for(int i = 0; i < Prices.Count; i++)
            {
                sb.Append(Prices[i]);
                if (i != Prices.Count-1)
                    sb.Append(", ");
            }
            return sb.ToString() + "))\n";
        }
    }
}
