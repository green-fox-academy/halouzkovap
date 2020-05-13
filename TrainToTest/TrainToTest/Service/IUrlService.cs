using System.Collections.Generic;
using TrainToTest.Enity;

namespace TrainToTest.Service
{
    public interface IUrlService
    {
        UrlAliaser FindAlias(string alias);
        UrlAliaser FindAlias(int id);
        void CreateUrl(string url, string alias);
        void CreateUrlObj(UrlAliaser aliaser);
        void UpdateUrl(UrlAliaser urlAliaser);
        IEnumerable<UrlAliaser> GetUrls();
        void DeleteUrl(int id);
        bool SecreteCode(int code, int id);

    }
}
