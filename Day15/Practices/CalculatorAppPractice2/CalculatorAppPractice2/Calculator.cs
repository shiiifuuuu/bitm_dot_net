using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {
        public double FirstNumber { set; get; }
        public double SecondNumber { set; get; }

        public Calculator(double firstNumber, double secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        public double Add()
        {
            return (FirstNumber + SecondNumber);
        }
        public double Subtract()
        {
            return (FirstNumber - SecondNumber);
        }
        public double Multiply()
        {
            return (FirstNumber * SecondNumber);
        }
        public double Divide()
        {
            return (FirstNumber/SecondNumber);
        }
    }
}
