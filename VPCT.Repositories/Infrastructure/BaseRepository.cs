using Microsoft.EntityFrameworkCore;
using VPCT.Core.DbContext;

namespace VPCT.Repositories.Infrastructure
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
          where TEntity : class
    {
        protected readonly VPCTDbContext dataContext;
        protected DbSet<TEntity> dbSet;

        protected BaseRepository(VPCTDbContext context)
        {
            dataContext = context;
            dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(params object[] primaryKey)
        {
            dbSet.Remove(dbSet.Find(primaryKey)!);
        }

        public TEntity Find(params object[] primaryKey)
        {
            return dbSet.Find(primaryKey)!;
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }
        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}
