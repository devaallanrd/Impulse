using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    interface IRepositorio<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> getAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
