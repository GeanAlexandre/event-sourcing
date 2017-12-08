using EventSourcing.Domain.Events;
using EventSourcing.Domain.Specifications;
using System;

using static EventSourcing.Shared.CommonOperations.CommonOperationMethods;

namespace EventSourcing.Domain.Models
{
    public class Account : Entity
    {
        private Account(decimal balance)
        {
            Id = Guid.NewGuid().ToString();
            Balance = balance;
        }

        public decimal Balance { get; private set; }
        public string Id { get; private set; }

        private IAccountSpecificationAbstractFactory Validator
            => new AccountSpecificationAbstractFactory();

        public void Deposit(decimal valueToDeposit)
        {
            var newBlance = Balance + valueToDeposit;
            Balance = valueToDeposit;
            Events.Add(new DepositMade(Id, Balance, newBlance));
        }

        public override string ToString() => $"The balance is: {Balance}";

        public void Withdraw(decimal valueToDraw)
        {
            var isValidValueToDraw = Validator
                .VerfiyTransferAccountSpecification.Factory()
                .IsSatisfiedBy(valueToDraw);

            If(isValidValueToDraw)
                .WhenIsTrue(() => DoWithDraw(valueToDraw));
        }

        private void DoWithDraw(decimal valueToDraw)
        {
            var newBlance = Balance - valueToDraw;
            Balance = newBlance;
            Events.Add(new WithDrawMade(Id, Balance, newBlance));
        }
    }
}
