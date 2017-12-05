namespace EventSourcing.Domain.Events
{
    public class DepositMade : IDomainEvent
    {
        public DepositMade(string id, decimal beforeValue, decimal currentValue)
        {
            Id = id;
            BeforeValue = beforeValue;
            CurrentValue = currentValue;
        }

        public string Id { get; private set; }
        public decimal BeforeValue { get; private set; }
        public decimal CurrentValue { get; private set; }
    }
}
