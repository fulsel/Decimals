using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 12;
            int chicken2 = 5;
            int chicken3 = 7;
            int chicken4 = 6;
            int sum = chicken1 + chicken2 + +chicken3 + chicken4;
            int dozen = sum / 12;
            int remainder = sum % 12;
            Console.WriteLine("If there are {0} total eggs, there are {1} dozen and {2} left over.", sum, dozen, remainder);
        }
    }
}
