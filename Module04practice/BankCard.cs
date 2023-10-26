using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04practice
{
    class BankCard
    {
        public bool IsBlocked { get; private set; }
        public decimal PaymentLimit { get; private set; }

        public BankCard(decimal paymentLimit)
        {
            PaymentLimit = paymentLimit;
        }

        public void BlockCard()
        {
            IsBlocked = true;
            Console.WriteLine("Карта заблокирована.");
        }

        public void SetPaymentLimit(decimal limit)
        {
            PaymentLimit = limit;
            Console.WriteLine($"Лимит платежей по карте установлен на {limit:C}.");
        }

        public void UpdatePayments(decimal paymentAmount)
        {
            PaymentLimit -= paymentAmount;
        }
    }
   }
