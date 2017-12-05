using EventSourcing.Domain.Events;
using System;

namespace EventSourcing.Domain.Models
{
    public class Account : Entity
    {
        public string Id { get; private set; }
        public decimal Balance { get; private set; }

        private Account(decimal balance)
        {
            Id = Guid.NewGuid().ToString();
            Balance = balance;
        }

        public void Withdraw(decimal valueToDraw)
        {
            var newBlance = Balance - valueToDraw;
            Balance = newBlance;
            Events.Add(new DepositMade(Id, Balance, newBlance));
        }

        public void Deposit(decimal valueToDeposit)
        {
            Balance += valueToDeposit;
        }

        public override string ToString() => $"The balance is: {Balance}";
    }
}
