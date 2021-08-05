using System;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Commands
{
    public sealed class UpdateClientCommand : ClientCommand
    {
        public static UpdateClientCommand Create(long codigo, string razaoSocial, string cnpj) =>
            new UpdateClientCommand
            {
                Codigo = codigo,
                RazaoSocial = razaoSocial,
                CNPJ = cnpj
            };
    }
}
