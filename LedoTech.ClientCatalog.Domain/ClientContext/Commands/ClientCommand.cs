using MediatR;
using System;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Commands
{
    public abstract class ClientCommand : IRequest
    {
        #region Properties
        public long Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }

        #endregion
        #region Constructor

        protected ClientCommand() { }

        #endregion
    }
}
