using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st01 = new Student(DateTime.Parse("01/10/1987"));
            Console.WriteLine(st01.BirthDay);
            Console.WriteLine(st01.Course);
            Console.ReadKey();
        }
    }
}
