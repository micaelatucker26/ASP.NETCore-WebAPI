namespace MarketAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
