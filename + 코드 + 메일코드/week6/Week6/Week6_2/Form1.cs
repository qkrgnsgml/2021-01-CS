using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_2
{
    public partial class Form1 : Form
    {
        List<Car> _cars = new List<Car>();//Car[] _cars = new Car[10];
        //int _currentCarCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string number = tbxNumber.Text.Trim();
            if (true == string.IsNullOrWhiteSpace(number))//null이거나 빈문자열이냐
            {
                MessageBox.Show("차량번호를 넣어주세요");
                return;
            }
            foreach(Car car in _cars)
            {
                if (car.CarNumber == number)
                {
                    MessageBox.Show("입고되어있음");
                    return;
                }
            }
            /*for (int i = 0; i < _cars.count; i++)
            {
                if (_cars[i].CarNumber == number)
                {
                    MessageBox.Show("입고되어있음");
                    return;
                }
            }*/

            Car newCar = new Car();
            newCar.CarNumber = number;
            newCar.InTime = (DateTime.Now).AddMinutes(-47);
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
            if (true == string.IsNullOrWhiteSpace(number))//null이거나 빈문자열이냐
            {
                MessageBox.Show("차량번호를 넣어주세요");
                return;
            }

            foreach(var car in _cars)
            {
                if(car.CarNumber == number)
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
            }
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
            MessageBox.Show("입고되어있지않음");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int i = 0; i < _cars.Count; i++)
            {
                message += string.Format("[{0}] 입고기간 :{1} 주차시간:{2}\r\n"
                    , _cars[i].CarNumber
                    , _cars[i].InTime
                    , _cars[i].ParkingTime()
                    );
            }

            tbxView.Text = message;
        }
    }
}
