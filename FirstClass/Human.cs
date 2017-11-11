using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Human
    {
        public string LastName;
        public string FirstName;
        public DateTime BirthDay;

        public Human() { }
        public Human(DateTime birthDay)
        {
            BirthDay = birthDay;
        }
    }
}
