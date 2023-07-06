using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public List<Item> AllItems()
        {
            return Items;
        }
        
        public double Total()
        {
            double total = 0D;
            foreach(var item in Items)
            {
                total += item.PriceInDollars();
            }
            return total;
        }
    }
}
