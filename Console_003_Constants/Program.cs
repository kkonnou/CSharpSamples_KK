using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_003_Constants
{
    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        // Create a constant of type string with your birthday as its value
        const string birthday = "31.05.1988";
        const string birthday2 = "05.31.1988";
        const string birthday3 = "2018-05-31";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.WriteLine("My birthday is always going to be: {birthday}");
            Console.WriteLine("My birthday is always going to be: " + birthday);
            Console.ReadKey();
        }
    }
}
