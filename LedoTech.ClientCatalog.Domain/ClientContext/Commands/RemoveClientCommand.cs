using System;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Commands
{
    public sealed class RemoveClientCommand : ClientCommand
    {
        public static RemoveClientCommand Create(long codigo) =>
            new RemoveClientCommand { Codigo = codigo };
    }
}
