using Light.Data.Entity;
using Light.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Light.Data.DataAccess.Ef.EfRepositories
{
    public class StoredProcedureRepository : EfRepository<BaseEntity>,  IStoredProcedureRepository
    {
        public StoredProcedureRepository(DbContext context) : base(context)
        {
        }

        public void Exec(string procedureName)
        {
            dbContext.Database.ExecuteSqlRaw(string.Format("exec {0}", procedureName));
        }

        public List<TEntity> Exec<TEntity>(string procedureName) where TEntity : BaseEntity
        {
            var sqlResult = dbContext.Set<TEntity>().FromSqlRaw(string.Format("exec {0}", procedureName));
            return sqlResult.ToList();
        }

        public List<TEntity> Exec<TEntity>(string procedureName, params string[] paramters) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
