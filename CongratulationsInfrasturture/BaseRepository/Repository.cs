using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongratulationsInfrasturture.BaseRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext DbContext { get; }
        protected DbSet<TEntity> DbSet { get; }
        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            await DbSet.AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            if(entity == null) throw new ArgumentNullException( nameof(entity));
            DbSet.Update(entity);
            await DbContext.SaveChangesAsync(); 
        }
    }
}
