using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_4
{
    //클래스는 자료의 형태를 정의한다.
    //  (복합 데이터 구조),(C언어의 구조체와 비슷)
    // Student라는 타입을 설계
    //int, double, string = 기본자료형
    //class로 만든 자료형은 사용자정의 자료형
    class Student
    {
        public String Num;//학번
        public String Name;//이름
        public double[] Scores = new double[3];//실수 변수 3개
    }
}
