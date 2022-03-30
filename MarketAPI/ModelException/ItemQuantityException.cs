namespace MarketAPI.ModelException
{
    /// <summary>
    /// Exception for an Item's quantity; thrown if the quantity is invalid
    /// </summary>
    public class ItemQuantityException : Exception
    {
        private int quantity;
        public int Quantity { get { return quantity; } }

        /// <summary>
        /// Default constructor for the Exception.
        /// Set as protected so it cannnot be used
        /// </summary>
        protected ItemQuantityException()
            : base()
        {

        }

        /// <summary>
        /// Exception for invalid quantity; uses the defualt message
        /// </summary>
        /// <param name="quantity">The invalid quantity</param>
        public ItemQuantityException(int quantity)
            : base(String.Format("{0} is an invalid quantity.", quantity))
        {
            this.quantity = quantity;
        }

        /// <summary>
        /// Exception for the invalid quantity; uses the message passed
        /// </summary>
        /// <param name="quantity">The invalid quantity</param>
        /// <param name="message">The custom exception message</param>
        public ItemQuantityException(int quantity, string message)
            : base(message)
        {
            this.quantity = quantity;
        }

        /// <summary>
        /// Exception for the invalid quantity; Takes a custom message
        /// and an inner exception
        /// </summary>
        /// <param name="quantity">The invalid quantity</param>
        /// <param name="message">The custom exception message</param>
        /// <param name="innerEx">The inner exception to throw</param>
        public ItemQuantityException(int quantity, string message, Exception innerEx)
            : base(message, innerEx)
        {
            this.quantity = quantity;
        }
    }
}
