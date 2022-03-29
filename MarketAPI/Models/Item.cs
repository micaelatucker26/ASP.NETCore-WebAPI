namespace MarketAPI.Models
{
    public class Item
    {
        #region Getters/Setters
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public Subcategory SubCategory { get; set; }
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
