using System;
using System.Threading.Tasks;
using Altan.Core.Common;
using Altan.Core.Shared.Dependency;

namespace Altan.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity;

        Task<int> SaveAsync();

        void Rollback();
    }
}