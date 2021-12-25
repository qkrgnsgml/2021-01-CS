using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_3
{
    class Car
    {

        public static int HalfHour_Charge = 1000;//30분당 1000원
        public static int TurningTime = 10;//분 회차
        //인스턴스변수
        public string CarNumber;
        public DateTime InTime;
        public DateTime OutTime;

        public int ParkingTime()
        {
            if (this.OutTime == DateTime.MinValue)//minvalue 1년1월1일 기본값 나갓는지아닌지
            {
                //안나갓는데 몇분주차ㅣ?
                return (int)(DateTime.Now - this.InTime).TotalMinutes;
            }
            else
            {
                //나감 몇분주차?
                return (int)(this.OutTime - this.InTime).TotalMinutes;
            }
        }

        public string PrintState()
        {
            int parkingTime = ParkingTime();
            string message;
            if (parkingTime > 0)
            {
                message = string.Format("[{0}] {1}분 주차", this.CarNumber, parkingTime);
            }
            else
            {
                message = string.Format("[{0}] 주차중", this.CarNumber);
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
