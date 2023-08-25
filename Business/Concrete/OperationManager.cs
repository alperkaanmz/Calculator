using Business.Absolute;
using DataAccess.Absolute;
using System.Data;
using System;

namespace Business
{
    public class OperationManager : IOperationManager
    {
        private IDatabaseManager databaseManager;

        public OperationManager(IDatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        public double Calculate(double firstNumber, string operation, double secondNumber)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        throw new DivideByZeroException("0'a bölünemez.");
                    }
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    throw new InvalidOperationException("Geçersiz işlem.");
            }

            string resultHistory = $"{firstNumber} {operation} {secondNumber}";
            databaseManager.SaveToDatabase(DateTime.Now, resultHistory, result.ToString());

            return result;
        }

        public DataTable LoadHistory()
        {
            return databaseManager.GetHistoryData();
        }

        public void ClearHistory()
        {
            databaseManager.ClearHistory();
        }

        public void DeleteLastEntry()
        {
            databaseManager.DeleteLastEntry();
        }
    }
}
