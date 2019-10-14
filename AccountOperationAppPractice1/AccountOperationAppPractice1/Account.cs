using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        public string customerName;
        public string accountNumber;
        public double blance;

        public double Deposit(double amnt)
        {
            blance = blance + amnt;
            return blance;
        }

        public double Widthraw(double amnt)
        {
            blance = blance - amnt;
            return blance;
        }
    }
}
