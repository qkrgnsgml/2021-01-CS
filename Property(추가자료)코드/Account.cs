using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperty
{
    class Account
    {
        private string _owner;
        private string _number;

        private int _balance;
        public int Balance
        {
            get
            {
                if(this._balance < 0)
                {
                    return 0;
                }
                else
                {
                    return this._balance;
                }
            }

            set
            {
                if(value >= 0)
                {
                    this._balance = value;
                }
            }
        }

        public int GetBalance() //getter method
        {
            if (this._balance < 0)
            {
                return 0;
            }
            else
            {
                return this._balance;
            }
        }
        
        public void SetBalance(int b) //setter method
        {
            if (b >= 0)//valid
            {
                this._balance = b;
            }
        }

        public Account(string o, string n, int b)
        {
            this._owner = o;
            this._number = n;
            this.Balance = b;//this._balance = b;
        }
    }
}
