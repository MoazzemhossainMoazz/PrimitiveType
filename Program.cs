using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveType
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Moazzem";
            var lastName = "Hossain";
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            const float Pi = 3.1416f;
            var age = 26;
            Console.WriteLine(Pi);
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}
