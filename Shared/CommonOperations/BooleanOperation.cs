using System;

namespace EventSourcing.Shared.CommonOperations
{
    public class BooleanOperation : IBooleanOperation
    {
        private readonly bool _booleanResult;

        public BooleanOperation(bool boolResult)
        {
            _booleanResult = boolResult;
        }

        public IBooleanOperation WhenIsFalse(Action whenIsFalseAction)
        {
            if (!_booleanResult)
                whenIsFalseAction?.Invoke();
            return this;
        }

        public IBooleanOperation WhenIsTrue(Action whenIsTrueAction)
        {
            if (_booleanResult)
                whenIsTrueAction?.Invoke();
            return this;
        }
    }
}
