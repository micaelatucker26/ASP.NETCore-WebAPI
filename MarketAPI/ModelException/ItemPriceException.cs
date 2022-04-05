namespace MarketAPI.ModelException
{
    /// <summary>
    /// Exception for an Item's pric; Thrown if the the price is not valid.
    /// </summary>
    public class ItemPriceException : ArgumentException
    {
        private double price;
        public double Price { get { return price; } }

        /// <summary>
        /// Default constructor for the Exception. 
        /// Set as protected so it cannot be used
        /// </summary>
        protected ItemPriceException()
            : base()
        {
            
        }

        /// <summary>
        /// Price exception for an invalid price. Contains a default message
        /// </summary>
        /// <param name="price">The invalid price</param>
        public ItemPriceException(double price)
            : base(String.Format("{0} is an invalid price.", price))
        {
            this.price = price;
        }

        /// <summary>
        /// Price exception for an invalid price. Takes a custom message
        /// </summary>
        /// <param name="price">The invalid price</param>
        /// <param name="message">The custom exception message</param>
        public ItemPriceException(double price, string message)
            : base(message)
        {
            this.price = price;
        }

        /// <summary>
        /// Price exception for an invalid price. 
        /// Takes a custom message and an inner exception
        /// </summary>
        /// <param name="price">The invalid price</param>
        /// <param name="message">The custom exception message</param>
        /// <param name="innerEx">The inner exception to throw</param>
        public ItemPriceException(double price, string message, Exception innerEx)
            : base(message, innerEx)
        {
            this.price = price;
        }
    }
}
