using System;

namespace TrainToTest.Enity
{
    public class UrlAliaser
    {
        public long Id { get; set; }
        public string UrlAdress { get; set; }
        public string Alias { get; set; }

        public int SecretCode { get; set; }
        public int HitCount { get; set; }
        public UrlAliaser()
        {

        }
        public UrlAliaser(string urlAdress, string alias)
        {
            this.UrlAdress = urlAdress;
            this.Alias = alias;

            var r = new Random();
            SecretCode = r.Next(1000, 9999);
        }
    }
}
