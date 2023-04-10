using Light.Data.DataAccess.Ef.EfRepositories;
using Light.Data.Entity;
using Light.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Light.Data.DataAccess.Ef
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public EfUnitOfWork()
        {
            _context = new ApiDbContext();

            _context.ChangeTracker.AutoDetectChangesEnabled = false;

            StoredProcedure = new StoredProcedureRepository(_context);
        }

        public IStoredProcedureRepository StoredProcedure { get; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            _context = null;
        }

        private Dictionary<string, object> repositories;

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            var entityName = (typeof(TEntity)).Name;
            if (repositories.ContainsKey(entityName))
            {
                return (IRepository<TEntity>)repositories.GetValueOrDefault(entityName);
            }
            else
            {
                var repository = new EfRepository<TEntity>(_context);
                repositories.Add(entityName, repository);
                return repository;
            }
        }
    }
}
