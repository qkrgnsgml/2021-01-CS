using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentindustrialEdu : Student
    {

        const int MAX_REG_SUBJECT = 4;

        private string _company;
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }

        public StudentindustrialEdu(string name, string id, int grade,string company)
            :base(name, id, grade)
        {
            _company = company;
        }

        public StudentindustrialEdu(string name, string id, string company)
            : base(name, id)
        {
            _company = company;
        }

        public new bool RegCourse(string subject)
        {
            bool result = false;

            if (_subject == null)
            {
                _subject = new List<string>();
            }
            if (_subject.Count < MAX_REG_SUBJECT)
            {
                string searchSubject = null;
                foreach (var sub in _subject)
                {
                    if (sub == subject)
                    {
                        searchSubject = sub;
                        break;
                    }
                }
                if (searchSubject == null)
                {
                    _subject.Add(subject);
                    result = true;
                }
            }
            return result;
        }

        public override bool RegCourseEx(string subject)
        {
            bool result = false;

            if (_subject == null)
            {
                _subject = new List<string>();
            }
            //LINQ
            //if (null == _subject.Where(m => m == subject).FirstOrDefault())
            //{
            //    _subject.Add(subject);
            //    result = true;
            //}         
            string searchSubject = null;
            foreach (var sub in _subject)
            {
                if (sub == subject)
                {
                    searchSubject = sub;
                    break;
                }
            }
            if (searchSubject == null)
            {
                _subject.Add(subject);
                result = true;
            }
            return result;
        }
    }
}
