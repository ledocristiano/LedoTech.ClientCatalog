using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(long id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
