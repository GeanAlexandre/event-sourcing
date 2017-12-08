namespace EventSourcing.Domain.Events
{
    public class WithDrawMade : IDomainEvent
    {
        public WithDrawMade(string id, decimal beforeValue, decimal currentValue)
        {
            CurrentValue = currentValue;
            BeforeValue = beforeValue;
            Id = id;
        }
        public decimal BeforeValue { get; }
        public decimal CurrentValue { get; }
        public string Id { get; }
    }
}
