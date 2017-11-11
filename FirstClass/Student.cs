using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Student : Human
    {
        public string University;
        public int Course;

        public Student()
            : base() { }
        public Student(DateTime birthDay)
            : base(birthDay)
        {
            Course = 1;
        }
    }

}
