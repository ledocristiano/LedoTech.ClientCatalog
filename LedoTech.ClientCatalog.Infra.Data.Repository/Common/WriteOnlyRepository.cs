using LedoTech.ClientCatalog.Domain.SharedContext.Interfaces.Repositories;
using LedoTech.ClientCatalog.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Infra.Data.Repository.Common
{
    public abstract class WriteOnlyRepository<TEntity> :
        IInsertableRepository<TEntity>,
        IUpdatableRepository<TEntity>,
        IRemovableRepository<TEntity> where TEntity : class
    {
        private readonly EFContext context;
        private readonly DbSet<TEntity> dbSet;

        protected WriteOnlyRepository()
        {
            context = new EFContext();
            dbSet = context.Set<TEntity>();
        }
        public async Task Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {
            dbSet.Update(entity);
            await context.SaveChangesAsync();
        }
        public async Task Remove(long codigo)
        {
            dbSet.Remove(await dbSet.FindAsync(codigo));
            await context.SaveChangesAsync();
        }
    }
}
