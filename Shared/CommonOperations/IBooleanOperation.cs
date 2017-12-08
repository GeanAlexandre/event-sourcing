using System;

namespace EventSourcing.Shared.CommonOperations
{
    public interface IBooleanOperation
    {
        IBooleanOperation WhenIsTrue(Action whenIsTrueAction);
        IBooleanOperation WhenIsFalse(Action whenIsTrueAction);
    }
}
