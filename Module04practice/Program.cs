using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04practice
{
    public class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000M);
            BankCard card = new BankCard(500M);
            Client client = new Client("Тима", account, card);
            Administrator admin = new Administrator();

            client.MakePayment(300M); // Платеж выполнен
            client.MakePayment(400M); // Превышен лимит платежа по карте
            admin.BlockCard(card);
            client.MakePayment(200M); // Карта заблокирована
        }
    }
}
