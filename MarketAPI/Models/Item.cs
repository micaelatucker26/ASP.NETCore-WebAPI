using MarketAPI.ModelException;

namespace MarketAPI.Models
{
    public class Item
    {
        #region Getters/Setters
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity 
        {
            get => this.Quantity;
            set
            {
                if(value < 0) // Check if quantity is valid
                {
                    throw new ItemQuantityException(value);
                }
            }
        }
        public double Price 
        {
            get => this.Price;
            set
            {
                if(value < 0) //Check if Price is valid
                {
                    throw new ItemPriceException(value);
                }
            }
        }
        public string ImageURL { get; set; }
        public SubCategory SubCategory { get; set; }
        #endregion



        /// <summary>
        /// Returns the value of this product in the store.
        /// </summary>
        /// <returns>The price of the product times the quantity</returns>
        public double calculateNetValue()
        {
            return this.Price * this.Quantity;
        }
    }
}
