using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surpass.ORM.Linq.Clauses
{
    /// <summary>
    /// 内部子语句
    /// </summary>
    interface IClause
    {
        /// <summary>
        /// Transforms all the expressions in this clause and its child objects via the given <paramref name="transformation"/> delegate.
        /// </summary>
        /// <param name="transformation">转换对象的委托 <see cref="Expression"/> within this  clause, and those expressions will be replaced with what the delegate returns.
        /// </param>      
        void TransformExpressions(Func<Expression, Expression> transformation);
    }
}
