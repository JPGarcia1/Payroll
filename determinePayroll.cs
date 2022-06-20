using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_test
{
    internal class determinePayroll : data
    {
        data myData = new data();
        public void payroll()
        {
            Console.Clear();
            Console.WriteLine("Type employed document: ");
            myData.Document = Console.ReadLine();

            Console.WriteLine("Type employed first name: ");
            myData.FirstName = Console.ReadLine();

            Console.WriteLine("Type employed last name: ");
            myData.LastName = Console.ReadLine();

            try
            {
                Console.WriteLine("Type employed salary: ");
                myData.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Type employed worked days: ");
                myData.WorkedDays = double.Parse(Console.ReadLine());
            }
            catch (Exception wrongValue)
            {
                Console.WriteLine("Wrong value \nPlease type a numeric value \n" +
                    "Type any key to continue");
                Console.ReadLine();
            }

            myData.TotalAccrue = myData.Salary / 30;
            myData.TotalAccrue = myData.TotalAccrue * myData.WorkedDays;

            myData.TransportSupport = 117172 / 30;
            myData.TransportSupport = myData.TransportSupport * myData.WorkedDays;

            myData.HealtDiscount = myData.TotalAccrue * 0.04;
            myData.PensionDiscount = myData.TotalAccrue * 0.04;

            if (myData.Salary <= 2000000)
            {
                myData.TotalAccrue = myData.TotalAccrue + myData.TransportSupport;
            }
            else
            {
                myData.TotalAccrue = myData.TotalAccrue;
            }
        }
        public void screenPrint()
        {
            StreamWriter sw = new StreamWriter("EmployedPayroll.txt", true);

            Console.WriteLine($"\nEmployed document: {myData.Document}\n");
            Console.WriteLine($"Employed first name: {myData.FirstName}\n");
            Console.WriteLine($"Employed last name: {myData.LastName}\n");
            Console.WriteLine($"Employed salary: {myData.Salary}\n");
            Console.WriteLine($"Employed worked days: {myData.WorkedDays}\n");
            Console.WriteLine($"Employed transport support if applicable: {myData.TransportSupport}\n");
            Console.WriteLine($"Employed healt discount: {myData.HealtDiscount}\n");
            Console.WriteLine($"Employed pension discount: {myData.PensionDiscount}\n");
            Console.WriteLine($"Employed total accrue: {myData.TotalAccrue}\n");

            sw.WriteLine(myData.Document+"\n"+ myData.FirstName+ "\n" + myData.LastName+ "\n" + myData.Salary+ "\n" + myData.WorkedDays
                + "\n" + myData.TransportSupport+ "\n" + myData.HealtDiscount+ "\n" + myData.PensionDiscount+ "\n" + myData +TotalAccrue+"\n");

            sw.Close();

            Console.WriteLine("Type any key to exit");
            string next = Console.ReadLine();
        }
    }
}