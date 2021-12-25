using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    class Test
    {

    }

    class BankSystem
    {            
        static List<Account> accounts= null;

        static void Main(string[] args)
        {
            //Account acc1 = new Account();
            Account acc2 = new Account("김인하", "111-111-111", 1000);
            Account acc3 = new Account("이인하", "211-111-111");

            acc2.Deposit(100000);
            acc2.Withdraw(2000);
            acc2.Owner = "박인하";
            Console.WriteLine(acc2.Owner);

            Console.WriteLine(acc2.Info());


            //accounts = new List<Account>();
            //Account acc1 = new Account();
            //Account acc2 = new Account();
            //
            //acc1._number = "111-111";
            //acc1._owner = "김인하";
            //acc1._balance = 1000;
            //
            //accounts.Add(acc1);  accounts.Add(acc2);
            //
            //accounts[0].Withdraw(10000);
            //acc1.Deposit(10);
            //acc2.Deposit(200);
            //accounts[1].Withdraw(1);
            //acc1._balance = 100000;
            //acc1._owner = "장은미";
            //
            //Console.WriteLine(acc1._balance);//?
            //Console.WriteLine(acc2._balance);//?            

        }
    }
}
