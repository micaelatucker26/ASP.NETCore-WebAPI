using MarketAPI.DataContext;
using MarketAPI.Models;
using MarketAPI.Repository;

namespace MarketAPI.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccess _dataAccess;

        public IItemRepository<Item> Item { get; private set; }
        public UnitOfWork(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            Item = new ItemRepository(_dataAccess);
        }
    }
}
