using LedoTech.ClientCatalog.Domain.CourseContext.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Domain.CourseContext.EventHandlers
{
    public sealed class ClientEventHandler : INotificationHandler<RegisteredClientEvent>
    {
        public async Task Handle(RegisteredClientEvent notification, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
