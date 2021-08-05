using LedoTech.ClientCatalog.Domain.CourseContext.Commands;
using LedoTech.ClientCatalog.Domain.CourseContext.Events;
using LedoTech.ClientCatalog.Domain.CourseContext.Interfaces.Repositories;
using LedoTech.ClientCatalog.Domain.CourseContext.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.CourseContext.CommandHandlers
{
    public sealed class ClientCommandHandler :
        IRequestHandler<RegisterClientCommand>,
        IRequestHandler<UpdateClientCommand>,
        IRequestHandler<RemoveClientCommand>
    {
        private readonly IMediator mediator;
        private readonly IClientWriteOnlyRepository clientWriteOnlyRepository;

        public ClientCommandHandler(IMediator mediator, IClientWriteOnlyRepository courseWriteOnlyRepository)
        {
            this.mediator = mediator;
            this.clientWriteOnlyRepository = courseWriteOnlyRepository;
        }

        public async Task<Unit> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            await clientWriteOnlyRepository.Add(Client.CreateToInsert(request.RazaoSocial, request.CNPJ, request.DataCadastro));
            await mediator.Publish(RegisteredClientEvent.Create(request.RazaoSocial), cancellationToken);

            return await Unit.Task;
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            await clientWriteOnlyRepository.Update(
                Client.CreateToUpdate(request.Codigo, request.RazaoSocial, request.CNPJ)
            );

            return await Unit.Task;
        }

        public async Task<Unit> Handle(RemoveClientCommand request, CancellationToken cancellationToken)
        {
            await clientWriteOnlyRepository.Remove(request.Codigo);
            return await Unit.Task;
        }
    }
}
