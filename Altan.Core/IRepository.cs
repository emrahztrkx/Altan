using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Altan.Core.Common;

namespace Altan.Core
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        T Add(T entity);

        Task<T> AddAsync(T entity);

        Task<T> FindAsync(int id);

        T Find(int id);

        Task<List<T>> GetAllAsync();

        List<T> GetAll();

        Task<T> Update(T entity);

        Task SaveChangesAsync();

        IQueryable<T> Query();

        void SaveChanges();
    }
}