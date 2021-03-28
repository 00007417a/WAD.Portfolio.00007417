using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        bool IfExists(int id);
    }
}
