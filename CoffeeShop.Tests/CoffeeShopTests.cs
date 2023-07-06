using CoffeeShop.Models;

namespace CoffeeShop.Tests
{
    public class CoffeeShopTests
    {
        [Fact]
        public void ItemPropertiesAreCreated()
        {
            Item item1 = new Item("coffee", 100);

            Assert.Equal("coffee", item1.Name);
            Assert.Equal(100, item1.PriceInCents);
        }

        [Fact]
        public void ItemPriceInDollarsMethod()
        {
            Item item1 = new Item("coffee", 100);
            Item item2 = new Item("coffee2", 1000);

            var price = item1.PriceInDollars();
            var price2 = item2.PriceInDollars();


            Assert.Equal(1.00, price);
            Assert.Equal(10.00, price2);
        }

        //order tests
        [Fact]
        public void OrderListOfItems_Created()
        {
            Order order1 = new Order();

            Assert.Equal(new List<Item>(), order1.Items);
        }

        [Fact]
        public void AddItemMethodAddsItem()
        {
            Item item1 = new Item("coffee", 100);
            Order order1 = new Order();
            
            order1.AddItem(item1);

            Assert.Equal(new List<Item> { item1 }, order1.Items);
        }

        [Fact]
        public void AllItemsReturnsAllItemsInOrder()
        {
            Item item1 = new Item("coffee", 100);
            Item item2 = new Item("coffee", 100);
            Item item3 = new Item("coffee", 100);
            Order order1 = new Order();

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);

            var items = order1.AllItems();

            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void OrderTotalReturnsTotalforOrder()
        {
            Item item1 = new Item("coffee", 100);
            Item item2 = new Item("coffee", 100);
            Item item3 = new Item("coffee", 100);
            Order order1 = new Order();

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);

            double total = order1.Total();

            Assert.Equal(3.00, total);
        }

        //customer tests

        [Fact]
        public void CustomerPropertiesCreated()
        {
            Customer customer1 = new Customer("Eli");

            Assert.Equal("Eli", customer1.Name);
            Assert.Equal(0, customer1.Orders.Count);
        }

        [Fact]
        public void AddOrderAddsOrder()
        {
            Customer customer1 = new Customer("Eli");
            Order order1 = new Order();

            customer1.AddOrder(order1);

            Assert.Equal(1, customer1.Orders.Count);

        }

        [Fact]
        public void AllOrdersRetursnAllOrders()
        {
            Customer customer1 = new Customer("Eli");
            Order order1 = new Order();
            Order order2 = new Order();

            customer1.AddOrder(order1);
            customer1.AddOrder(order2);

            var orders = customer1.AllOrders();

            Assert.Equal(2, orders.Count);
        }
    }
}