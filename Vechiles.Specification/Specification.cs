using System;
using System.Linq.Expressions;

namespace Vechiles.Specification
{
    public class Specification<TEntity> : ISpecification<TEntity>
        where TEntity: class
    {
        #region Fields

        public Expression<Func<TEntity, bool>> Expression { protected set; get; }

        #endregion Fields

        #region Constructors

        public Specification()
        {
 
        }

        public Specification(Expression<Func<TEntity, bool>> expression)
        {
            this.Expression = expression;
        }

        #endregion Constructors
    }
}