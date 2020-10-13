using Mercado.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mercado.Domain.Repository.Abstract
{
    public class MarketRepository<TEntity, TKey> : IMarket<TEntity, TKey>, IDisposable where TEntity : Entity<TKey>
    {
        private readonly DbContext _dbContext;

        private readonly DbSet<TEntity> _dbSet;

        public MarketRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public void Alter(TEntity entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public TEntity Get(TKey key)
        {
            return _dbSet.Find(key);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> List()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public void Remove(TKey key)
        {
            var entity = Get(key);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
