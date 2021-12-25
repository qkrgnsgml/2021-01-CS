using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Test
    {
        
    }

    class BankSystem
    {
        static List<Account> accounts;
        static void Main(string[] args)
        {
            accounts = new List<Account>();

            Account acc1 = new Account("장은미", "1111", 1000);
            
            acc1.Deposit(10000);
            acc1.Withdraw(10);

            acc1.Owner = "김은미";
            string name = acc1.Owner;
            Console.WriteLine(name);


            Console.WriteLine(acc1.Info());
        }
    }
}
