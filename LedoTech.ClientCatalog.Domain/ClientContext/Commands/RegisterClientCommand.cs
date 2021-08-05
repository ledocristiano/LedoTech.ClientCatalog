using System;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Commands
{
    public sealed class RegisterClientCommand : ClientCommand
    {
        public static RegisterClientCommand Create(string razaoSocial, string cnpj) =>
            new RegisterClientCommand
            {
                RazaoSocial = razaoSocial,
                CNPJ = cnpj,
                DataCadastro = DateTime.Now
            };
    }
}
