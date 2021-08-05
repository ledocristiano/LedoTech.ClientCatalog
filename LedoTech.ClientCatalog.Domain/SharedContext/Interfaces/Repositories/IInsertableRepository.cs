using System;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories
{
    public interface IInsertableRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
    }
}
