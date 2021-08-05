using System;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories
{
    public interface IRemovableRepository<TEntity> where TEntity : class
    {
        Task Remove(long id);
    }
}
