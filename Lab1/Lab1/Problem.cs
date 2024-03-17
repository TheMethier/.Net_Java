using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Lab1Tests"), InternalsVisibleTo("Lab1GUI")]
namespace Lab1
{
    internal class Problem
    {
        public int Seed { get; set; }
        public int NumberOfItems { get; set; }
        public List<Item> Items { get; set; }
        public Problem()
        {
            this.Items = new List<Item>();
        }
        public Problem(int seed, int numberOfItems)
        {
            Seed = seed;
            this.NumberOfItems = numberOfItems;
            Random random = new Random(seed);
            this.Items = new List<Item>();
            for(int i = 0; i < numberOfItems; i++) {
                this.Items.Add(new Item(i,random.Next(1,10), random.Next(1,10)));
            }
        }
        public Problem(List<Item> items)
        {
            this.Items= items;
            this.NumberOfItems = items.Count;
            this.Seed = 69;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Item item in this.Items)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public Result Solve(int capacity)
        {
            Result result = new Result();
            List<Item> itemsInOrder = this.Items
                .OrderByDescending(x=>(double)(x.Value)/(double)(x.Weight))
                .ToList();
            List<Item> items = new List<Item>();
            int totalWeight = 0;
            foreach(Item item in itemsInOrder)
            {
                if(capacity>=totalWeight+item.Weight)
                {
                    items.Add(item);
                    totalWeight += item.Weight;
                }
            }
            result.Items = items;
            return result;
        }
        
    }
}
