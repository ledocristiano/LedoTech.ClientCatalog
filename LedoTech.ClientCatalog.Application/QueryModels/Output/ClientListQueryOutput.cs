using System;

namespace LedoTech.ClientCatalog.Application.QueryModels.Output
{
    public sealed class ClientListQueryOutput
    {
        public long Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }

        public static ClientListQueryOutput Create(long codigo, string razaoSocial, string cnpj, DateTime dataCadastro) =>
          new ClientListQueryOutput
          {
              Codigo = codigo,
              RazaoSocial = razaoSocial,
              CNPJ = cnpj,
              DataCadastro = dataCadastro
          };
    }
}
