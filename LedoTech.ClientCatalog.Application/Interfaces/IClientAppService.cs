using LedoTech.ClientCatalog.Application.InputModels;
using LedoTech.ClientCatalog.Application.QueryModels.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Application.Interfaces
{
    public interface IClientAppService
    {
        Task Register(ClientInputModel clientInputModel);
        Task Update(ClientInputModel clientInputModel);
        Task Remove(long codigo);
        Task<IEnumerable<ClientListQueryOutput>> GetAllClients();
        Task<ClientOutput> Get(long codigo);
    }
}
