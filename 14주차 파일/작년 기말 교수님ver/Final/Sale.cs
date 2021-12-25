using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Sale
    {
        public int Number
        {
            get;
            private set;
        }

        public int ProdNumber
        {
            get;
            private set;
        }

        public DateTime Date
        {
            get;
            private set;
        }

        public int Count
        {
            get;            
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public Sale(int number, int prodnumber, DateTime date, int count, int price)
        {
            this.Number = number;
            this.ProdNumber = prodnumber;
            this.Date = date;
            this.Count = count;
            this.Price = price;

        }
    }
}
