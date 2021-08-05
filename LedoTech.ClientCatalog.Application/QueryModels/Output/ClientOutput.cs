using System;
using System.Collections.Generic;
using System.Text;

namespace LedoTech.ClientCatalog.Application.QueryModels.Output
{
    public sealed class ClientOutput
    {
        public long Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }

        public static ClientOutput Create(long codigo, string razaoSocial, string cnpj, DateTime dataCadastro) =>
          new ClientOutput
          {
              Codigo = codigo,
              RazaoSocial = razaoSocial,
              CNPJ = cnpj,
              DataCadastro = dataCadastro
          };
    }
}
