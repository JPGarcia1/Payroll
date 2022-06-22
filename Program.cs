using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll_test
{
    internal class Program
    {
        public static void Main(string[]args)
        {
            determinePayroll payroll = new determinePayroll();
            string opc;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to payroll program\n");
                Console.WriteLine("1. Determine an employed payroll.");
                Console.WriteLine("2. Exit.");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        payroll.payroll();
                        payroll.screenPrint();
                        payroll.TextWriter();
                        break;
                    case "2":
                        Console.WriteLine("\nLeaving the program.");
                        break;
                    default:
                        Console.WriteLine("\nPlease type a correct value\n");
                        Console.WriteLine("Type any key to continue");
                        string next = Console.ReadLine();
                        break;
                }
            }
            while (opc != "2"); 

        }
    }
}