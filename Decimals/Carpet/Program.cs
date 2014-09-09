using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
           int Length = 10;
           int width = 15;
           int area = Length * width;
           double cost = area * 1.5;
            
           Console.WriteLine("if the length is {0} and the width is {1} then the area is {2}. This makes the cost {3}.", Length, width, area, cost.ToString("C"));

        }
    }
}
