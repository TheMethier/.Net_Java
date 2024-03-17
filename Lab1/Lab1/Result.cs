using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Lab1GUI")]

namespace Lab1
{
    internal class Result
    {
        public List<Item> Items { get; set; }

        public Result(List<Item> items)
        {
            Items = items;
        }
        public Result() {
            Items = new List<Item>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int totalWeight = 0;
            int totalValue=0;
            sb.Append("items: ");
            foreach (Item item in Items)
            {
                sb.Append(item.Id +" ");
                totalWeight += item.Weight;
                totalValue += item.Value;
            }
            sb.AppendLine();
            sb.AppendLine("total value: " + totalValue).AppendLine("total weight: " + totalWeight);
            return sb.ToString();
        }
    }
}
