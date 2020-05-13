using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TrainToTest.DbTTT;
using TrainToTest.Enity;

namespace TrainToTest.Service
{
    public class UrlService : IUrlService
    {
        private readonly TrainToTestDbContext trainToTestDb;

        public UrlService(TrainToTestDbContext trainToTestDb)
        {
            this.trainToTestDb = trainToTestDb;
        }

        public void CreateUrl(string url, string alias)
        {
            var urlA = new UrlAliaser(url, alias);
            trainToTestDb.UrlAliasers.Add(urlA);
            trainToTestDb.SaveChanges();
        }

        public void CreateUrlObj(UrlAliaser aliaser)
        {
            trainToTestDb.UrlAliasers.Add(aliaser);
            trainToTestDb.SaveChanges();
        }

        public void DeleteUrl(int id)
        {
            var url = trainToTestDb.UrlAliasers.Find(id);
            trainToTestDb.UrlAliasers.Remove(url);
            trainToTestDb.SaveChanges();
        }

        public UrlAliaser FindAlias(string alias)
        {
            return trainToTestDb.UrlAliasers.FirstOrDefault(x => x.Alias == alias);
        }

        public UrlAliaser FindAlias(int id)
        {
            return trainToTestDb.UrlAliasers.Find(id);

        }

        public IEnumerable<UrlAliaser> GetUrls()
        {
            return trainToTestDb.UrlAliasers;
        }

        public bool SecreteCode(int code, int id)
        {
            var url = trainToTestDb.UrlAliasers.Find(id);
            if (url != null)
            {
                if (url.SecretCode == code)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public void UpdateUrl(UrlAliaser urlAliaser)
        {
            trainToTestDb.Entry(urlAliaser).State = EntityState.Modified;
            trainToTestDb.SaveChanges();
        }
    }
}
