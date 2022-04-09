using MarketAPI.ModelException;
using MarketAPI.Models;
using System;
using Xunit;

namespace MarketAPI_Testing
{
    /// <summary>
    /// Unit tests for the Item class
    /// </summary>
    public class UnitTestItem : IDisposable
    {
        private SubCategory subCategory;

        #region Test Setup and Destroy

        /// <summary>
        /// Test Setup
        /// </summary>
        public UnitTestItem()
        {
            subCategory  = new SubCategory();

            subCategory.Name = "SubCat";
        }

        /// <summary>
        /// Test Destroy
        /// </summary>
        public void Dispose()
        {
            subCategory = null;
        }

        #endregion

        #region Unit Tests

        /// <summary>
        /// Unit test for the Item paramaterized constructor
        /// Tests for good getters and setters within the class
        ///     called by the constructor
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="description">Item description</param>
        /// <param name="quantity">Item quantity</param>
        /// <param name="price">Item price</param>
        /// <param name="imageURL">Ite image URL</param>
        [Theory]
        [InlineData("ItemName", "ItemDesc", 3, 2.50, "./res/item.jpg")]
        [InlineData("ItemName", "ItemDesc", 0, 0, "./res/item.jpg")]
        [InlineData("ItemName", "ItemDesc", int.MaxValue, double.MaxValue, "./res/item.jpg")]
        public void Item_Constructor(string name, string description, int quantity, double price, string imageURL)
        {
            Item i = new Item(name, description, quantity, price, imageURL, subCategory);

            Assert.Equal(name, i.Name);
            Assert.Equal(description, i.Description);
            Assert.Equal(quantity, i.Quantity);
            Assert.Equal(price, i.Price);
            Assert.Equal(imageURL, i.ImageURL);
            Assert.Equal(subCategory.Name, i.SubCategory.Name);
        }

        /// <summary>
        /// Unit test for the paramaterized constructor throwing an exception
        /// Tests the Item.Price setter to make sure it throws an exception 
        ///     when a bad price is passed
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="description">Item description</param>
        /// <param name="quantity">Item quantity</param>
        /// <param name="price">Item price</param>
        /// <param name="imageURL">Ite image URL</param>
        [Theory]
        [InlineData("ItemName", "ItemDesc", 3, -1, "./res/item.jpg")]
        [InlineData("ItemName", "ItemDesc", 3, double.MinValue, "./res/item.jpg")]
        public void Item_Constructor_ItemEx(string name, string description, int quantity, double price, string imageURL)
        {
            var ex = Assert.Throws<ItemPriceException>(() => new Item(name, description, quantity, price, imageURL, subCategory));
        }

        /// <summary>
        /// Unit test for the paramaterized constructor throwing an exception
        /// Tests the Item.Quantity setter to make sure it throws an exception
        ///     when a bad quantity is passed
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="imageURL"></param>
        [Theory]
        [InlineData("ItemName", "ItemDesc", -1, 2.50, "./res/item.jpg")]
        [InlineData("ItemName", "ItemDesc", int.MinValue, double.MaxValue, "./res/item.jpg")]
        public void Item_Constructor_QuantityEx(string name, string description, int quantity, double price, string imageURL)
        {
            var ex = Assert.Throws<ItemQuantityException>(() => new Item(name, description, quantity, price, imageURL, subCategory));
        }

        #endregion
    }
}