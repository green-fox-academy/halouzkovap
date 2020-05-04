using Frontend.DatabaseContext;
using Frontend.Entities;
using System.Collections.Generic;

namespace Frontend.Services
{
    public class LogServices : ILogServices
    {
        private readonly FrontendDbContext dbContext;

        public LogServices(FrontendDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<LogObject> GetLogs()
        {
            return dbContext.Logs;
        }

        public void SaveLog(LogObject log)
        {
            dbContext.Add(log);
            dbContext.SaveChanges();
        }
    }
}
