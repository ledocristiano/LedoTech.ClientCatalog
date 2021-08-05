using Dapper.Contrib.Extensions;
using LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories;
using LedoTech.ClientCatalog.Infra.CrossCutting.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Infra.Data.Repository.Common
{
    public abstract class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            using (var connection = GetConnection())
                return await connection.GetAllAsync<TEntity>();
        }
        protected SqlConnection GetConnection()
        {
            var connection = new SqlConnection(Configuration.GetDefaultConnectionString());
            connection.Open();
            return connection;
        }

        public async Task<TEntity> GetById(long codigo)
        {
            using (var connection = GetConnection())
                return await connection.GetAsync<TEntity>(codigo);
        }
    }
}
