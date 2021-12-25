using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_4
{
    class Car
    {
        //생성자가 1개도 없다면 컴파일러가 기본생성자를 만들어줌
        //public Car(){}
        public static int HalfHour_Charge = 1000;//30분당 1000원
        public static int TurningTime = 10;//분 회차
        //인스턴스변수
        string _carNumber;
        DateTime _inTime;
        DateTime _outTime;

        public int ParkingTime()
        {
            if (this._outTime == DateTime.MinValue)//minvalue 1년1월1일 기본값 나갓는지아닌지
            {
                //안나갓는데 몇분주차ㅣ?
                return (int)(DateTime.Now - this._inTime).TotalMinutes;
            }
            else
            {
                //나감 몇분주차?
                return (int)(this._outTime - this._inTime).TotalMinutes;
            }
        }
        public Car()
        {

        }

        public Car(string number)
        {
            _carNumber = number;
            _inTime = DateTime.Now;
        }

        public string PrintState()
        {
            int parkingTime = ParkingTime();
            string message;
            if (parkingTime > 0)
            {
                message = string.Format("[{0}] {1}분 주차", this._carNumber, parkingTime);
            }
            else
            {
                message = string.Format("[{0}] 주차중", this._carNumber);
            }
            return message;
        }

        public int CalcParkingCharge()
        {
            //주차시간 계산 >회차시간 내인지 확인>회차시간 안이면 0원 아니면 계산해서 돈계산 30분 *요금 
            int parktime = ParkingTime();//분단위

            if (parktime <= TurningTime)
            {
                return 0;
            }
            else
            {
                var halfHour = parktime / 30;
                var remainder = parktime % 30;
                var totalcharge = (halfHour * HalfHour_Charge)
                    + (remainder > 0 ? HalfHour_Charge : 0);

                return totalcharge;
            }
        }
    }
}
