using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Subject
    {
        const double MAX = 100.0;
        const double MIN = 0.0;

        public string Title//과목명
        {
            get;
            set;
        }
                
        private double? _score; //점수
        public double? Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value == null || value < MIN || value > MAX)
                {
                    _score = null;
                }
                else
                {
                    _score = value;
                }
            }
        }

        public Subject(string title)
        {
            Title = title;
            Score = null;
        }
    }

    class RegSubjectList
    {
        List<Subject> subjects = new List<Subject>();

        public Subject this[int index]
        {
            get
            {
                if (index < subjects.Count && index >= 0)
                {
                    return subjects[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count
        {
            get
            {
                return subjects.Count;
            }
        }

        public bool RegSubject(string title)
        {
            try
            {
                subjects.Add(new Subject(title));
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                //throw ex; 여기서 에러 처리하기 싫으면 caller로 던짐
            }
        }

        public bool SetScore(string title, double score)
        {
            bool result = false;

            for(int i=0; i < subjects.Count; i++)
            {
                if(subjects[i].Title == title)
                {
                    subjects[i].Score = score;
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool Avg(out double value)
        {
            bool result = false;
            value = 0.0;

            double sum = 0;
            int count = 0;

            foreach(var sub in subjects)
            {
                if (sub.Score != null)
                {
                    sum += (double)sub.Score;
                    count++;
                }
            }

            if (count > 0)
            {
                value = sum / count;
                result = true;
            }

            return result;
        }

    }

    class Student
    {
        public string Name;
        public RegSubjectList RegSubjects = new RegSubjectList();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "김인하";
            double avg = 0.0;

            if(student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균:" + avg);
            }
            else
            {
                Console.WriteLine("평균없음");
            }

            student.RegSubjects.RegSubject("영어");
            student.RegSubjects.RegSubject("국어");
            student.RegSubjects.RegSubject("수학");

            if (student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균:" + avg);
            }
            else
            {
                Console.WriteLine("평균없음");
            }

            student.RegSubjects.SetScore("국어",100);
            student.RegSubjects.SetScore("영어",50);

            if (student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균:" + avg);
            }
            else
            {
                Console.WriteLine("평균없음");
            }


            //단, foreach는 사용할 수 없다.
            for(int i=0; i < student.RegSubjects.Count; i++)
            {
                Subject sub = student.RegSubjects[i];
                Console.WriteLine($"{sub.Title}-{sub.Score??0}");
            }
        }
    }
}
