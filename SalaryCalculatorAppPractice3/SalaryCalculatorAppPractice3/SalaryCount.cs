using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class SalaryCount
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double madicaleAllowance;
        public double salary;
       

        public double HouseRent()
        {
            salary = (basicAmount * houseRent / 100);
            return salary;
        }

        public double MadicaleAllowance()
        {
            salary = (basicAmount * houseRent / 100);
            return salary;
        }

        public void Show()
        {
            string message;
            message = "Name :" + employeeName + "\n" + "Salary" + salary + "\n";
        }

    }
}
