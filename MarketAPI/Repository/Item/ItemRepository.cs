using MarketAPI.Classes;
using MarketAPI.DataContext;
using MarketAPI.Models;

namespace MarketAPI.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository<Item>
    {
        private readonly DataAccess _dataAccess;
        //private readonly ILogger _logger;

        public ItemRepository(DataAccess dataAccess)// ILogger logger
        {
            _dataAccess = dataAccess;
            //_logger = logger;
        }

        public Item Add(Item item)
        {
            Item newItem = new Item();
           // newItem = _dataAccess.SaveNewObject<Item>(item);
            return newItem;
        }

        public Item GetByID(int id)
        {
            Item item = new Item();
            //item = _dataAccess.LoadObject<Item>(id);
            return item;
        }
        public IEnumerable<Item> GetAll()
        {
            IEnumerable<Item> items = new List<Item>();
            //items = _dataAccess.LoadObjects<Item>();
            return items;
        }

        
        public void Update(int id)
        {
            //_dataAccess.SaveObject<Item>(id);
        }

        public void Delete(int id)
        {
            //_dataAccess.DeleteObject<Item>(id);
        }

        public SubCategory GetSubcategory(int id)
        {
            // call the method in the subcategory controller to get a subcategory by its id
            // and pass the id from this method, to store the specific subcategory
            return null;
        }
    }
}

