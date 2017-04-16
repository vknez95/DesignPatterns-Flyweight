using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFrameworkStringIntern
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "flyweight";

            string s2 = "flyweight";

            //string s2 = s1;

            //string s2 = string.Intern(Console.ReadLine()); 

            string s3 = "---";

            string s4 = new string('-', 3);

            // string s5 = string.Intern(new string('-', 3));

            Console.WriteLine(ReferenceEquals(s3, s4));
        }
    }
}
