namespace MarketAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T>GetByID(int ID);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(int ID);
        Task<T>Delete(int ID);

    }
}
