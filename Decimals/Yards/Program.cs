using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            int areafeet = length * width;
            double yards = areafeet / 9;
            double cost = yards * 1.5;
            Console.WriteLine("If the length is {0}, and yards width is {1}, the square yards is {2} and the cost is {3}.", length, width, yards, cost.ToString("C"));



        }
    }
}
