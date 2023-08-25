using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absolute
{
    public interface IDatabaseManager
    {
        void SaveToDatabase(DateTime resultDate, string resultHistory, string result);
        DataTable GetHistoryData();
        void ClearHistory();
        void DeleteLastEntry();
    }
}
