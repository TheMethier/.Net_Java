using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Lab1Tests")]
[assembly: InternalsVisibleTo("Lab1GUI")]

namespace Lab1
{

    internal class Item
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }
        public Item() { }
        public Item(int id, int weight, int value) {
            Weight = weight;
            Value = value;
            Id = id;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("no.: "+Id+" v: " + Value+" w: "+Weight);
            return stringBuilder.ToString();
        }
    }
}
