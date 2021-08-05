using LedoTech.ClientCatalog.Domain.CourseContext.Interfaces.Repositories;
using LedoTech.ClientCatalog.Domain.CourseContext.Models;
using LedoTech.ClientCatalog.Infra.Data.Repository.Common;

namespace LedoTech.ClientCatalog.Infra.Data.Repository.Dapper
{
    public sealed class ClientReadOnlyRepository : ReadOnlyRepository<Client>, IClientReadOnlyRepository
    {
    }
}
