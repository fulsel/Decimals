using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name ");
            name = Console.ReadLine();

            string socialsecurity;
            Console.Write("Enter your social security number ");
            socialsecurity = Console.ReadLine();

            string payrate;
            Console.Write("Enter your hourly pay rate ");
            payrate = Console.ReadLine();
            double PayRate = Convert.ToDouble(payrate);

            string hours;
            Console.Write("Enter the number of hours worked ");
            hours = Console.ReadLine();
            Double Hours = Convert.ToDouble(hours);

            Console.WriteLine("");

            double gross = Hours * PayRate;
            double federal = gross * .15;
            double state = gross * .05;
            double net = gross - federal - state;

            Console.WriteLine("Your gross pay is {0}.", gross.ToString("C"));
            Console.WriteLine("Federal tax - {0}", federal.ToString("C"));
            Console.WriteLine("State tax - {0}", state.ToString("C"));
            Console.WriteLine("Your net pay is {0}", net.ToString("C"));

            

        }
    }
}
