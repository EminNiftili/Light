using Light.Data.Entity;

namespace Light.Data.Repositories
{
    public interface IStoredProcedureRepository
    {
        public void Exec(string procedureName);
        List<TEntity> Exec<TEntity>(string procedureName) where TEntity : BaseEntity;
        List<TEntity> Exec<TEntity>(string procedureName, params string[] paramters) where TEntity : BaseEntity;
    }
}
