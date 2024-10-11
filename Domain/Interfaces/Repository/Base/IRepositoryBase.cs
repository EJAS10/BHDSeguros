using System.Linq.Expressions;

namespace FactBHDSegurosuracion.Domain.Interfaces.Repository.Base
{
    public interface IRepositoryBase<T>
    {
        void Insert(T Entity);
        void Update(T Entity);
        void Deleted(Expression<Func<T, bool>> where);
    }
}
