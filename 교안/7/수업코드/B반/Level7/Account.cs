using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    class Account
    {
        private static int _maxBalance = 100000000;

        private string _owner;
        public string Owner
        {
            get { return this._owner; }
            private set { this._owner = value; }
        }

        private string _number;
        private int _balance;

        //public Account()//기본생성자
        //{
        //
        //}

        public Account(string name, string number, int money)//사용자정의생성자
        {
            this._owner = name;
            this._number = number;
            this._balance = money;
        }

        public Account(string name, string number)//사용자정의생성자
        {
            this._owner = name;
            this._number = number;
            //this._balance = 0;
        }

        public bool Deposit(int amount)
        {
            if (this._balance + amount > Account._maxBalance)
            {
                return false;
            }
            else
            {
                this._balance += amount;
                return true;
            }
        }


        public bool Withdraw(int amount)
        {
            if(this._balance - amount < 0) 
            {
                return false;
            }
            else
            {
                this._balance -= amount;
                return true;
            }
        }

        public string Info()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("번호:").Append(this._number);
            builder.Append(Environment.NewLine);
            builder.Append("이름:").Append(this._owner);
            builder.Append(Environment.NewLine);
            builder.Append("잔액:").Append(this._balance);            

            return builder.ToString();
        }
    }
}
