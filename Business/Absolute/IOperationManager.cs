using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absolute
{
    public interface IOperationManager
    {
        double Calculate(double firstNumber, string operation, double secondNumber);
        DataTable LoadHistory();
        void ClearHistory();
        void DeleteLastEntry();
    }
}
