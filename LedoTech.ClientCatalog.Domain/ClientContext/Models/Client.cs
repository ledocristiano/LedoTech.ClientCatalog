using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace LedoTech.ClientCatalog.Domain.CourseContext.Models
{
    public class Client
    {
        #region Properties
        [ExplicitKey]
        public long Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }

        #endregion
        #region Constructor

        private Client() { }

        #endregion
        #region Factory Methods

        public static Client CreateToInsert(string razaoSocial, string cnpj, DateTime dataCadastro) =>
            new Client
            {
                RazaoSocial = razaoSocial,
                CNPJ = cnpj,
                DataCadastro = dataCadastro
            };

        public static Client CreateToUpdate(long codigo, string razaoSocial, string cnpj) =>
            new Client
            {
                Codigo = codigo,
                RazaoSocial = razaoSocial,
                CNPJ = cnpj
            };

        #endregion
    }
}
