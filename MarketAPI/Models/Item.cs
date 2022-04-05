using MarketAPI.ModelException;

namespace MarketAPI.Models
{
    public class Item
    {
        private int _quantity;
        private double _price;

        #region Getters/Setters
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity 
        {
            get { return this._quantity; }
            set
            {
                if(value < 0) // Check if quantity is valid
                {
                    throw new ItemQuantityException(value);
                }

                this._quantity = value;
            }
        }
        public double Price 
        {
            get { return this._price; }
            set
            {
                if(value < 0) //Check if Price is valid
                {
                    throw new ItemPriceException(value);
                }

                this._price = value;
            }
        }
        public string ImageURL { get; set; }
        public SubCategory SubCategory { get; set; }
        #endregion

        /// <summary>
        /// Paramaterized constructor for the Item class. 
        /// Allows for creating a custom Item
        /// </summary>
        /// <param name="Name">The name of an item</param>
        /// <param name="Description">A basic description of an item</param>
        /// <param name="Quantity">The quanitiy of items</param>
        /// <param name="Price">The price of an item</param>
        /// <param name="ImageURL">The imageURL of an item</param>
        /// <param name="subCategory">The subcategory and item is in</param>
        public Item
            ( 
                string Name, 
                string Description, 
                int Quantity, 
                double Price, 
                string ImageURL, 
                SubCategory subCategory
            )
        {
            this.Name = Name;
            this.Description = Description;
            this.Quantity = Quantity;
            this.Price = Price;
            this.ImageURL = ImageURL;
            this.SubCategory = subCategory;
        }

        /// <summary>
        /// Default constructor for an item.
        /// Sets all instance variables to default values
        /// </summary>
        public Item()
        {

        }

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
