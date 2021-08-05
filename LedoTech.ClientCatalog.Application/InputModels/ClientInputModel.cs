using System;
using System.Collections.Generic;
using System.Text;

namespace LedoTech.ClientCatalog.Application.InputModels
{
    public sealed class ClientInputModel
    {
        public long Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
