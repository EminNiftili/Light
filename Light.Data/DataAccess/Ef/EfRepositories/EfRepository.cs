using Light.Data.Entity;
using Light.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public abstract class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
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

        public TEntity GetEntity(object value, string columnName)
        {
            throw new NotImplementedException();
            //return entities.FirstOrDefault(x =>
            //{
            //    var prop = x.GetType().GetProperties().FirstOrDefault(p => p.Name == columnName);
            //    return prop != null && prop.GetValue(x) == value;
            //}
            //);
        }

        public List<TEntity> Gets()
        {
            return Gets(x => true);
        }

        public List<TEntity> Gets(Expression<Func<TEntity, bool>> expression)
        {
            return entities.Where(expression).ToList();
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
