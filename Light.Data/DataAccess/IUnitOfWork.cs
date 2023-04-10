using Light.Data.Entity;
using Light.Data.Repositories;

namespace Light.Data.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        IStoredProcedureRepository StoredProcedure { get; }

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
    }
}
