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

            string price = item1.PriceInDollars();

            Assert.Equal("1.00", price);
        }
    }
}