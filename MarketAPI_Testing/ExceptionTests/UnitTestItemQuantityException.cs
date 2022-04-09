using MarketAPI.ModelException;
using System;
using Xunit;

namespace MarketAPI_Testing.ExceptionTests
{
    /// <summary>
    /// Unit testing class for the ItemQuantityException 
    /// </summary>
    public class UnitTestItemQuantityException : IDisposable
    {
        private int quantity;
        private string defaultMessage;
        private string customMessage;

        #region Test Setup and Destroy

        /// <summary>
        /// Test Setup
        /// </summary>
        public UnitTestItemQuantityException()
        {
            quantity = -1;
            defaultMessage = String.Format("{0} is an invalid quantity.", quantity);
            customMessage = String.Format("{0} cannot be used as a quantity!", quantity);
        }

        /// <summary>
        /// Test Destroy
        /// </summary>
        public void Dispose()
        {
            quantity = 0;
        }

        #endregion

        #region Class Unit Tests

        /// <summary>
        /// Unit test for the Quantity Exceptions default message constructor
        /// </summary>
        [Fact]
        public void Quantity_Exception_DefaultMessage()
        {
            var ex = Assert.Throws<ItemQuantityException>(() => throwDefault());
            Assert.Equal(defaultMessage, ex.Message);
            Assert.Equal(quantity, ex.Quantity);
        }

        /// <summary>
        /// Unit test for the Quantity Exceptions custom message constructor
        /// </summary>
        [Fact]
        public void Quantity_Exception_CustomMessage()
        {
            var ex = Assert.Throws<ItemQuantityException>(() => throwCustom());
            Assert.Equal(customMessage, ex.Message);
            Assert.Equal(quantity, ex.Quantity);
        }

        /// <summary>
        /// Unit test for the Quantity Exceptions inner exception constructor
        /// </summary>
        [Fact]
        public void Quantity_Exception_WithInner()
        {
            var ex = Assert.Throws<ItemQuantityException>(() => throwWithInner());
            Assert.Equal(customMessage, ex.Message);
            Assert.Equal(quantity, ex.Quantity);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Throws the Quantity Exception as a default message
        /// </summary>
        /// <exception cref="ItemQuantityException"></exception>
        private void throwDefault()
        {
            throw new ItemQuantityException(quantity);
        }

        /// <summary>
        /// Throws the Quantity Exception with a custom message
        /// </summary>
        /// <exception cref="ItemQuantityException"></exception>
        private void throwCustom()
        {
            throw new ItemQuantityException(quantity, customMessage);
        }

        /// <summary>
        /// Throws the Quantity Exceptiom with an inner exception
        /// </summary>
        /// <exception cref="ItemQuantityException"></exception>
        private void throwWithInner()
        {
            throw new ItemQuantityException(quantity, customMessage, new Exception());
        }

        #endregion
    }
}
