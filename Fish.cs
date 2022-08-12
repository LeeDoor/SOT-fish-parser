using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishes_SOT_parser
{
    public class Fish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public List<int> Prices { get; set; }
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
        public bool IsDataEmpty()
        {
            return
                (string.IsNullOrEmpty(Name) ||
                string.IsNullOrEmpty(Type) ||
                Prices.Count != 8);
        }
        public void BuildPath()
        {
            var words = Name.Split();
            Path = "\"images\\fishes\\" 
                + char.ToUpper(words[0][0]) 
                + words[0].Substring(1)
                + "_"
                + char.ToUpper(words[1][0])
                + words[1].Substring(1)
                + ".png\"";
        }
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
        public string ToBuilderString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($".BuildFish(\n" + 
                $"\"{Name}\",\n" +
                $"{Path},\n" +
                $"new Location(),\n" +
                $"new Price(");
            for(int i = 0; i < Prices.Count; i++)
            {
                sb.Append(Prices[i]);
                if (i != Prices.Count-1)
                    sb.Append(", ");
            }
            return sb.ToString() + ")\n";
        }
    }
}
