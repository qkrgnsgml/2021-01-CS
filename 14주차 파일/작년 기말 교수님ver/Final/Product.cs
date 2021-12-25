using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Product
    {
        public int Number
        {
            private set;
            get;
        }

        public string Name
        {
            private set;
            get;
        }

        public int StockCount
        {
            private set;
            get;
        }

        public int UnitPrice
        {
            get;
            set;
        }

        public double DiscountRate
        {
            get;
            set;
        }

        public Product(int number, string name, int stockcount, int unitprice, double discountreate)
        {
            this.Number = number;
            this.Name = name;
            this.StockCount = stockcount;
            this.UnitPrice = unitprice;
            this.DiscountRate = discountreate;
        }

        public void AddStockCout(int addcount)
        {
            this.StockCount += addcount;
        }

        public int Sale(int count)
        {
            if(count > StockCount)
            {
                throw new Exception("재고수량 없음");//의도적으로 오류를 발생시킴.
            }
            else
            {
                this.StockCount -= count;
                return (int)((count * this.UnitPrice) * (count >= 30 ? (1.0 - this.DiscountRate) : 1.0));
            }
        }

    }
}
