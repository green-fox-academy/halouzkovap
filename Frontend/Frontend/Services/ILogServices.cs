using Frontend.Entities;
using System.Collections.Generic;

namespace Frontend.Services
{
    public interface ILogServices
    {
        public void SaveLog(LogObject log);

        IEnumerable<LogObject> GetLogs();
    }
}
