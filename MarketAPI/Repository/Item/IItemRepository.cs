using MarketAPI.Models;

namespace MarketAPI.Repository
{
    public interface IItemRepository<T> : IRepository<T> where T : Item
    {
        Item Add(Item item);
        Item GetByID(int id);
        IEnumerable<Item> GetAll();
        void Update(int id);
        void Delete(int id);
        SubCategory GetSubcategory(Item item);

    }
}