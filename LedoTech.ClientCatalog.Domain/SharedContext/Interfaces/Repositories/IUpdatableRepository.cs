using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories
{
    public interface IUpdatableRepository<TEntity> where TEntity : class
    {
        Task Update(TEntity entity);
    }
}
