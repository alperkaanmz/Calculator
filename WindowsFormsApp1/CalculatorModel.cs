using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorModel
    {
        private OperationManager operationManager = new OperationManager();

        public double FirstNumber { get; private set; }
        public string Operation { get; private set; }

        public string Calculate(string expression)
        {
            string[] expressionParts = expression.Split(' ');

            if (expressionParts.Length != 3)
            {
                return "Geçerşiz işlem.";
            }

            try
            {
                double secondNumber = Convert.ToDouble(expressionParts[2]);
                double result = operationManager.Calculate(FirstNumber, Operation, secondNumber);

                string resultHistory = $"{FirstNumber} {Operation} {secondNumber}";
                operationManager.SaveToDatabase(DateTime.Now, resultHistory, result.ToString());

                return result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Geçersiz işlem.";
            }
        }

        public void SetOperation(string operation)
        {
            Operation = operation;
        }

        public void SetFirstNumber(double number)
        {
            FirstNumber = number;
        }
    }
}
