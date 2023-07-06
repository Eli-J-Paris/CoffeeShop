using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> AllOrders()
        {
            return Orders;
        }

        public double TotalSpent()
        {
            double total = 0D;
            foreach (var order in Orders)
            {
                foreach(var item in order.Items)
                {
                    total += item.PriceInDollars();
                }
            }
            return total;
        }

        public List<Item> ItemsOrdered()
        {
            List<Item> allItems = new List<Item>();
            foreach (var order in Orders)
            {
                foreach (var item in order.Items)
                {
                   if(allItems!.Contains(item))
                    {
                        allItems.Add(item);
                    }
                }
            }
            return allItems;
        }
    }
}
