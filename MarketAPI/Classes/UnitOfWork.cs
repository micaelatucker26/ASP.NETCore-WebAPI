using MarketAPI.DataContext;
using MarketAPI.Models;
using MarketAPI.Repository;

namespace MarketAPI.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccess _dataAccess;
        private readonly ILogger _logger;

        public IItemRepository<Item> Item { get; private set; }
        public UnitOfWork(DataAccess dataAccess, ILoggerFactory loggerFactory)
        {
            _dataAccess = dataAccess;
            _logger = loggerFactory.CreateLogger("logs");
            Item = new ItemRepository(_dataAccess); //(_dataAccess, _logger)
        }
    }
}
