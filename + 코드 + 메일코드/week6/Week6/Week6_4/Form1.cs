using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_4
{
    public partial class Form1 : Form
    {
        List<Car> _cars = new List<Car>();//Car[] _cars = new Car[10];
        //int _currentCarCount = 0;
        public Form1()//생성자,특수메소드 반환타입이없음class이름과 동일
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();

            if (!CheckCarNumber(number))
            {
                MessageBox.Show("차량번호 제대로쓰셈");
                return;
            }

            if (SearchCar(number) != null)
            {
                MessageBox.Show("입고되어있음");
                return;
            }

            /*foreach (Car car in _cars)
            {
                if (car.CarNumber == number)
                {
                    MessageBox.Show("입고되어있음");
                    return;
                }
            }*/
            /*for (int i = 0; i < _cars.count; i++)
            {
                if (_cars[i].CarNumber == number)
                {
                    MessageBox.Show("입고되어있음");
                    return;
                }
            }*/

            Car newCar = new Car(number);
            //newCar.CarNumber = number;
            //newCar.InTime = (DateTime.Now).AddMinutes(MakeTestTime());


            _cars.Add(newCar);

            //_cars[_currentCarCount] = new Car();
            //_cars[_currentCarCount].CarNumber = number;
            //var now_datetime = (DateTime.Now).AddMinutes(-47);//47분전
            //_cars[_currentCarCount].InTime = now_datetime;

            //TEST

            //_currentCarCount++;

            MessageBox.Show($"{number}입고완료");
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();

            if (!CheckCarNumber(number))
            {
                MessageBox.Show("차량번호 제대로쓰셈");
                return;
            }

            var car = SearchCar(number);
            if (car != null)
            {
                car._outTime = DateTime.Now;
                int charge = car.CalcParkingCharge();
                int min = car.ParkingTime();

                if (charge == 0)
                {
                    MessageBox.Show($"회차 차량입니다.[{min}]분");

                }
                else
                {
                    MessageBox.Show(string.Format("{0}분 주차 / {1}원", min, charge));
                }

                this._cars.Remove(car);
            }
            else
            {
                MessageBox.Show("입고되어있지않음");
            }

            /*foreach (var car in _cars)
            {
                if (car.CarNumber == number)
                {
                    car.OutTime = DateTime.Now;
                    int charge = car.CalcParkingCharge();
                    int min = car.ParkingTime();

                    if (charge == 0)
                    {
                        MessageBox.Show($"회차 차량입니다.[{min}]분");

                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0}분 주차 / {1}원", min, charge));
                    }

                    this._cars.Remove(car);
                }
            }*/
            /*for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].CarNumber == number)
                {
                    _cars[i].OutTime = DateTime.Now;
                    int charge = _cars[i].CalcParkingCharge();
                    int min = _cars[i].ParkingTime();

                    if (charge == 0)
                    {
                        MessageBox.Show($"회차 차량입니다.[{min}]분");

                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0}분 주차 / {1}원", min, charge));
                    }
                    //_cars.RemouveAt(i);
                    _cars.Remove(_cars[i]); 
                    return;
            }
                }*/
            //MessageBox.Show("입고되어있지않음");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int i = 0; i < _cars.Count; i++)
            {
                message += string.Format("[{0}] 입고기간 :{1} 주차시간:{2}\r\n"
                    , _cars[i]._carNumber
                    , _cars[i]._inTime
                    , _cars[i].ParkingTime()
                    );
            }

            tbxView.Text = message;
        }

        //메소드 정의
        private bool CheckCarNumber(string number)
        {
            Regex regx = new Regex(@"^[0-9]{2,3}[가-힣]{1}[0-9]{4}$");
            Match m = regx.Match(number);
            return m.Success;
        }

        //Form1의 인스턴스 변수
        //메소드 오버로딩
        //메소드 이름은 동일 매개변수 타입과 갯수 다르면 ㄱㅊ
        Random rand = new Random();
        private int MakeTestTime()
        {
            return rand.Next(-70, 0);
        }
        private int MakeTestTime(int min)
        {
            return rand.Next(min, 0);
        }
        private int MakeTestTime(int min, int max)
        {
            return rand.Next(min, max);
        }

        private Car SearchCar(string number)
        {
            foreach (var car in _cars)
            {
                if (car._carNumber == number)
                {
                    return car;
                }
            }

            return null;
        }
    }
}
