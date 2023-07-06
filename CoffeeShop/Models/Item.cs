using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceInCents { get; set; }


        public Item(string name, double priceInCents)
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public string PriceInDollars()
        {
           string price = Math.Round(PriceInCents, 2).ToString();
            return price;
        }
    }
}
