using Frontend.Entities;
using System.Collections.Generic;

namespace Frontend.Services
{
    public interface ILogServices
    {
        public void SaveLog(LogObject log);

        IEnumerable<LogObject> GetLogs();
        IEnumerable<LogObject> GetLatestLogs(int number);
        IEnumerable<LogObject> GetSecondLatestLogs(int number, int page);
        IEnumerable<LogObject> SearchLog(string search);

    }
}
