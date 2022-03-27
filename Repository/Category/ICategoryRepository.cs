using MarketAPI.Models;

namespace MarketAPI.Repository
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {
        
    }
}
