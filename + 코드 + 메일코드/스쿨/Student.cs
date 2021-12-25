using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        private int _grade;
        public int Grade
        {
            get
            {
                return _grade;
            }

            set
            {
                _grade = value;
            }
        }

        protected List<string> _subject;
        public List<string> Subject
        {
            get
            {
                return _subject;
            }
        }
        public Student(string name, string id) //: this(name, id, 1)

        {

            _name = name;
            _id = id;
            _grade = 1;
            _subject = new List<string>();
        }

        public Student(string name, string id, int grade)
            : this(name, id)
        {
            Grade = grade; //SetGrade(grade);
        }

        public bool RegCourse(string subject)
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
            foreach(var sub in _subject)
            {
                if(sub == subject)
                {
                    searchSubject = sub;
                    break;
                }
            }
            if(searchSubject == null)
            {
                _subject.Add(subject);
                result = true;
            }
            return result;
        }

        public virtual bool RegCourseEx(string subject)
        {
            bool result = false;

            if (_subject == null)
            {
                _subject = new List<string>();
            }     
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
