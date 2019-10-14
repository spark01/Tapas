using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double madicaleAllowance;
        public double salary;
        public double res;

        public double Totalsalary()
        {
            res= basicAmount + (houseRent * basicAmount / 100) + (madicaleAllowance * basicAmount / 100);
            return res;
        }
    }
}
