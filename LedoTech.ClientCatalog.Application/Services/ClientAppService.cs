using LedoTech.ClientCatalog.Application.InputModels;
using LedoTech.ClientCatalog.Application.Interfaces;
using LedoTech.ClientCatalog.Application.QueryModels.Output;
using LedoTech.ClientCatalog.Domain.CourseContext.Commands;
using LedoTech.ClientCatalog.Domain.CourseContext.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Application.Services
{
    public sealed class ClientAppService : IClientAppService
    {
        private readonly IMediator mediator;
        private readonly IClientReadOnlyRepository clientReadOnlyRepository;

        public ClientAppService(IMediator mediator, IClientReadOnlyRepository clientReadOnlyRepository)
        {
            this.mediator = mediator;
            this.clientReadOnlyRepository = clientReadOnlyRepository;
        }

        public async Task Register(ClientInputModel clientInputModel) =>
            await mediator.Send(RegisterClientCommand.Create(clientInputModel.RazaoSocial, clientInputModel.CNPJ));

        public async Task Update(ClientInputModel clientInputModel) =>
              await mediator.Send(UpdateClientCommand.Create(
                clientInputModel.Codigo, clientInputModel.RazaoSocial, clientInputModel.CNPJ));

        public async Task<IEnumerable<ClientListQueryOutput>> GetAllClients()
        {
            var list = await clientReadOnlyRepository.GetAll();
            return list.Select(x => ClientListQueryOutput.Create(x.Codigo, x.RazaoSocial, x.CNPJ, x.DataCadastro));
        }

        public async Task Remove(long codigo) => await mediator.Send(RemoveClientCommand.Create(codigo));

        public async Task<ClientOutput> Get(long codigo)
        {
            var model = await clientReadOnlyRepository.GetById(codigo);
            if (model == null)
                return null;

            return ClientOutput.Create(model.Codigo, model.RazaoSocial, model.CNPJ, model.DataCadastro);
        }
    }
}
