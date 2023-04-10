using Light.Data.Entity;
using System.Linq.Expressions;

namespace Light.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        void Update(T entity);
        void Update(IEnumerable<T> entity);
        T GetEntity(int id);
        T GetEntity(object value, string columnName);
        List<T> Gets();
        List<T> Gets(Expression<Func<T, bool>> expression);
    }
}
