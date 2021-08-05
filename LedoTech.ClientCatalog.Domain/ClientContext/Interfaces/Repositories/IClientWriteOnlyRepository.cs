using LedoTech.ClientCatalog.Domain.CourseContext.Models;
using LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Interfaces.Repositories
{
    public interface IClientWriteOnlyRepository :
        IInsertableRepository<Client>,
        IUpdatableRepository<Client>,
        IRemovableRepository<Client>
    {
    }
}
