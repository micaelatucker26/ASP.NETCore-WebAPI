using MarketAPI.ModelException;
using System;
using Xunit;

namespace MarketAPI_Testing.ExceptionTests
{
    /// <summary>
    /// Unit testing class for the ItemPriceException 
    /// </summary>
    public class UnitTestItemPriceException : IDisposable
    {
        private double price;
        private string defaultMessage;
        private string customMessage;

        #region Test Setup and Destroy

        /// <summary>
        /// Test Setup
        /// </summary>
        public UnitTestItemPriceException()
        {
            price = -1.0;
            defaultMessage = String.Format("{0} is an invalid price.", price);
            customMessage = String.Format("{0} cannot be used as a price!", price);
        }

        /// <summary>
        /// Test Destroy
        /// </summary>
        public void Dispose()
        {
            price = 0;
        }

        #endregion

        #region Class Unit Tests

        /// <summary>
        /// Unit test for the Price Exceptions default message constructor
        /// </summary>
        [Fact]
        public void Price_Exception_DefaultMessage()
        {
            var ex = Assert.Throws<ItemPriceException>(() => throwDefault());
            Assert.Equal(defaultMessage, ex.Message);
            Assert.Equal(price, ex.Price);
        }

        /// <summary>
        /// Unit test for the Price Exceptions custom message constructor
        /// </summary>
        [Fact]
        public void Price_Exception_CustomMessage()
        {
            var ex = Assert.Throws<ItemPriceException>(() => throwCustom());
            Assert.Equal(customMessage, ex.Message);
            Assert.Equal(price, ex.Price);  
        }

        /// <summary>
        /// Unit test for the Price Exceptions inner exception constructor
        /// </summary>
        [Fact]
        public void Price_Exception_WithInner()
        {
            var ex = Assert.Throws<ItemPriceException>(() => throwWithInner());
            Assert.Equal(customMessage, ex.Message);
            Assert.Equal(price, ex.Price);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Throws the Price Exception as a default message
        /// </summary>
        /// <exception cref="ItemPriceException"></exception>
        private void throwDefault()
        {
            throw new ItemPriceException(price);
        }

        /// <summary>
        /// Throws the Price Exception with a custom message
        /// </summary>
        /// <exception cref="ItemPriceException"></exception>
        private void throwCustom()
        {
            throw new ItemPriceException(price, customMessage);
        }

        /// <summary>
        /// Throws the Price Exceptiom with an inner exception
        /// </summary>
        /// <exception cref="ItemPriceException"></exception>
        private void throwWithInner()
        {
            throw new ItemPriceException(price, customMessage, new Exception());
        }

        #endregion
    }
}
