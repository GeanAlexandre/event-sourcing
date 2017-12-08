namespace EventSourcing.Shared.CommonOperations
{
    public static class CommonOperationMethods
    {
        public static IBooleanOperation If(bool boolResult) => new BooleanOperation(boolResult);
    }
}
