using MarketAPI.Models;
using MarketAPI.Repository;

namespace MarketAPI.Classes
{
    public interface IUnitOfWork
    {
        IItemRepository<Item> Item { get; }
    }
}