using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public int FirstNumber;
        public int SeceoandNumber;
        public float Result;
        
        public float Add( )
        {
            Result = FirstNumber + SeceoandNumber;
            return Result;
        }
        public float Sub()
        {
            Result = FirstNumber - SeceoandNumber;
            return Result;
        }
        public float Mul()
        {
            Result = FirstNumber * SeceoandNumber;
            return Result;
        }
        public float Div()
        {
            Result = FirstNumber / SeceoandNumber;
            return Result;
        }
    }
    
}
