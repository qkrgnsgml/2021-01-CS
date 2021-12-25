using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c샵_5_2
{
    class Car
    {
        public string CarNumber;
        public DateTime InTime;
        public DateTime OutTime;

        public int ParkingTime()
        {
            return (int)(this.OutTime - this.InTime).TotalMinutes;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.Write("차량번호:");
            car.CarNumber = Console.ReadLine();
            //string number = car.CarNumber.Trim(); 
            // 아래 if문에서 그냥 String.IsNullOrEmpty(car.CarNumber)나 car.CarNumber.Length == 0 햇을때 공백이 있으면 진행되는데 한문장으로 어떻게 자르는지 모르겟음...
            if (String.IsNullOrEmpty(car.CarNumber))
            {
                Console.WriteLine("차량번호를 제대로 입력해주세요");
                return;
            } //if (car.CarNumber.Length != 8) { (if (car.CarNumber.Length != 9){ 차량번호 제대로 return;})}
            Console.Write("입고시간(예:2012/4/3 12:03:03):");
            bool b = DateTime.TryParse(Console.ReadLine(),out car.InTime);
            if (b == false)
            {
                Console.WriteLine("입고시간의 형식이 잘못되었습니다.");
                return;
            }
            Console.Write("출고시간(예:2012/4/3 14:07:03):");
            string a = Console.ReadLine();
            #region
            string[] OutTimes = a.Split(' ');//날짜 형식을 공백으로 두부분으로 나누고
            string[] OutTimes2 = OutTimes[0].Split('/'); // 앞부분을 / 로 나누고
            string[] OutTimes3 = OutTimes[1].Split(':'); // 뒷부분을 :로 나눈뒤 아래에서 입력한 값이 숫자 인지 확인
            bool q = int.TryParse(OutTimes2[0],out int z);
            bool w = int.TryParse(OutTimes2[1], out int x);
            bool e = int.TryParse(OutTimes2[2], out int c);
            bool r = int.TryParse(OutTimes3[0], out int v);
            bool t = int.TryParse(OutTimes3[1], out int n);
            bool y = int.TryParse(OutTimes3[2], out int m);
#endregion//출고시간검사
            if (q & w & e & r & t & y)
            {
                car.OutTime = new DateTime(z,x,c,v,n,m);
            Console.WriteLine(car.PrintState());
            }
            else
            {
                Console.WriteLine("출고시간의 형식이 잘못되었습니다.");
                return;
            }
            #region
            /*if (a.Length != 17)//문제점 > 형식은 틀렷는데 길이만 맞을경우 정상적으로 작동함
            {
                if(a.Length == 0)
                {
                    Console.WriteLine(car.PrintState());
                    return;
                }
                Console.WriteLine("출고시간의 형식이 잘못되었습니다.");
                return;
            }*/
            // Console.WriteLine(car.PrintState());
            //string InTime2 = Console.ReadLine();
            //string a = Console.ReadLine()
            //string[] InTimes = InTime2.Split(' ');
            //car.InTime = new DateTime();
            #endregion//하다가 바뀐 것들 주석처리
        }
    }
}
