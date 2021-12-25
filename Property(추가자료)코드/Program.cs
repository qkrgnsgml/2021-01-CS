using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("김땡땡", "111-111-11111", -100);
            
            #region Setter/Getter

            acc.SetBalance(-1000);
            Console.WriteLine(acc.GetBalance());

            #endregion

            #region Property

            acc.Balance = 2000;
            Console.WriteLine(acc.Balance);

            #endregion
        }
    }
}
