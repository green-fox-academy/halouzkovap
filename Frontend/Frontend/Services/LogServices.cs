using Frontend.DatabaseContext;
using Frontend.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Services
{
    public class LogServices : ILogServices
    {
        private readonly FrontendDbContext dbContext;

        public LogServices(FrontendDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<LogObject> GetLatestLogs(int number)
        {
            return dbContext.Logs.OrderByDescending(x => x.Data).Take(number);
        }

        public IEnumerable<LogObject> GetLogs()
        {
            return dbContext.Logs;
        }

        public IEnumerable<LogObject> GetSecondLatestLogs(int number, int page)
        {
            return dbContext.Logs.OrderByDescending(x => x.Data).Skip(number * (page - 1)).Take(number);

        }

        public void SaveLog(LogObject log)
        {
            dbContext.Add(log);
            dbContext.SaveChanges();
        }

        public IEnumerable<LogObject> SearchLog(string search)
        {
            return dbContext.Logs.Where(x => x.Data.Contains(search) || x.Endpoint.Contains(search));
        }
    }
}
