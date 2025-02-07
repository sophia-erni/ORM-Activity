using System.Linq.Expressions;

namespace ORM_Activity.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAll(params Expression<Func<T, object>>[] includes);
        Task<T> Add(T entity);
    }
}
