namespace MarketAPI.Models
{
    public class SubCategory
    {
        #region Getters/Setters
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
