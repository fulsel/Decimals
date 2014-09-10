using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 197;
            int hours = minutes / 60;
            int remainder = minutes % 60;
            Console.WriteLine("{0} minutes becomes {1} hours and {2} minutes.", minutes, hours, remainder);
        }
    }
}
