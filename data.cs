using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_test
{
    internal class data
    {
        private string document;
        private string firstName;
        private string lastName;
        private double salary;
        private double workedDays;
        private double totalAccrue;
        private double transportSupport;
        private double healtDiscount;
        private double pensionDiscount;

        public data()
        {

        }

        public string Document { get => document; set => document = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Salary { get => salary; set => salary = value; }
        public double WorkedDays { get => workedDays; set => workedDays = value; }
        public double TotalAccrue { get => totalAccrue; set => totalAccrue = value; }
        public double TransportSupport { get => transportSupport; set => transportSupport = value; }
        public double HealtDiscount { get => healtDiscount; set => healtDiscount = value; }
        public double PensionDiscount { get => pensionDiscount; set => pensionDiscount = value; }
    }
}
