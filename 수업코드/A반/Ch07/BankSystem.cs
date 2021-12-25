using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    class Test
    {

    }

    class BankSystem
    {
        static List<Account> accounts;
        static void Main(string[] args)
        {
            //Account acc1 = new Account();
            Account acc2 = new Account("장은미", "1111-22-222", 1000);
            Account acc3 = new Account("김인하", "1111-22-221");

            acc2.Deposit(20000);
            acc2.Withdraw(1000);

            //acc2._balance = 100;
            //acc2._owner = "111";
            acc2.Owner = "111";
            Console.WriteLine(acc2.Owner);

            Console.WriteLine(acc2.Info());

            //accounts = new List<Account>();
            //
            //Account acc1 = new Account();
            //Account acc2 = new Account();
            //
            //accounts.Add(acc1);
            //accounts.Add(acc2);
            //
            //acc1.Deposit(100);
            //accounts[0].Withdraw(50);
            //accounts[1].Withdraw(100);
            //acc2.Deposit(300);
            //
            //Console.WriteLine(acc1._balance); //?
            //Console.WriteLine(acc2._balance); //?
            //
            //acc1._balance = 100000;
            //acc1._owner = "김인하";
            //acc1._number = "111-111-1-1111";
            //
            //Console.WriteLine(acc1._balance);
            //Console.WriteLine(acc1._owner);
            //Console.WriteLine(acc1._number);
        }
    }
}
