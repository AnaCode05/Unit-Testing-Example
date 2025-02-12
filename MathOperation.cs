using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_UnitTestingExample
{
    /// <summary>
    /// Calculator class that performs various mathematical operations involving 2 integers
    /// </summary>
    public class MathOperation
    {
        // Operation attributes
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public char? OperationSymbol { get; set; }


        /// <summary>
        /// MathOperation default constructor (parameterless)
        /// </summary>
        public MathOperation()
        {
            FirstNumber = 1; 
            SecondNumber = 1;
            OperationSymbol = null;
        }

        /// <summary>
        /// MathOperation constructor with parameters
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="operation"></param>
        public MathOperation(int firstNumber, int secondNumber, char operationSymbol)
        {
            FirstNumber = firstNumber; 
            SecondNumber = secondNumber;
            OperationSymbol = operationSymbol;
        }

        /// <summary>
        /// Performs a mathematical operation of the 2 integers specified in the constructor based on the operation parameter
        /// </summary>
        /// <param name="operation"></param>
        /// <returns>Answer to operation (sum, difference, product, or quotient)</returns>
        public double PerformOperation()
        {
            switch (OperationSymbol)
            {
                case '+':
                    return FirstNumber + SecondNumber;
                case '-':
                    return FirstNumber - SecondNumber;
                case '*':
                    return FirstNumber * SecondNumber;
                case '/':
                    return FirstNumber / SecondNumber;
                default:
                    return FirstNumber + SecondNumber;
            }
        }
    }
}
