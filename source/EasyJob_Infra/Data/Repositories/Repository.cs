using EasyJob_Business.Core.Data;
using EasyJob_Business.Core.Model;
using EasyJob_Infra.Data.DbAplications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EasyJob_Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly DbApplication Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DbApplication db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            Db.Entry<TEntity>(entity).State = EntityState.Modified;
            await SaveChanges();
        }

        public virtual async Task Delete(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted; //SOFT DELETE
            await SaveChanges();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
