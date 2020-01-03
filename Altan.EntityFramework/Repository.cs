using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Altan.Core;
using Altan.Core.Common;
using Microsoft.EntityFrameworkCore;

namespace Altan.EntityFramework
{
    public sealed class Repository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly AltanDbContext _context;

        public Repository(AltanDbContext context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<T>().Remove(entity);
            return entity;
        }

        public async Task<T> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Query()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}