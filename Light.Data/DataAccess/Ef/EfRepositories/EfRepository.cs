using Light.Data.Entity;
using Light.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext dbContext;
        protected DbSet<TEntity > entities;
        public EfRepository(DbContext context)
        {
            dbContext = context;
            entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entity)
        {
            entities.AddRange(entity);
        }

        public TEntity GetEntity(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public List<TEntity> Gets()
        {
            return Gets(x => true);
        }

        public List<TEntity> Gets(Expression<Func<TEntity, bool>> expression)
        {
            return entities.Where(expression).ToList();
        }

        public IQueryable<TEntity> Queryable()
        {
            return entities.AsQueryable();
        }

        public void Update(TEntity entity)
        {
            entities.Update(entity);
        }

        public void Update(IEnumerable<TEntity> entity)
        {
            entities.UpdateRange(entity);
        }
    }
}
