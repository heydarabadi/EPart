using System.Linq.Expressions;

namespace Shared.Application;

public sealed class TrueSpecification<T> : Specification<T>
{
    public override Expression<Func<T, bool>> ToExpression() => x => true;
}