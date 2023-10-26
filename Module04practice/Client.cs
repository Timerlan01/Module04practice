using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04practice
{
    public class Client
    {
        public string Name { get; }
        public BankAccount Account { get; }
        public BankCard Card { get; }

        public Client(string name, BankAccount account, BankCard card)
        {
            Name = name;
            Account = account;
            Card = card;
        }

        public void MakePayment(decimal amount)
        {
            if (Card.IsBlocked)
            {
                Console.WriteLine("Ошибка: Карта заблокирована.");
            }
            else if (amount > Card.PaymentLimit)
            {
                Console.WriteLine("Ошибка: Превышен лимит платежа по карте.");
            }
            else
            {
                Account.MakePayment(amount);
                Card.UpdatePayments(amount);
                Console.WriteLine($"Платеж в размере {amount:C} выполнен.");
            }
        }
    }
}
