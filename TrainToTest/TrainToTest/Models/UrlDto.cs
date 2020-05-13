namespace TrainToTest.Models
{
    public class UrlDto
    {
        public long Id { get; set; }
        public string UrlAdress { get; set; }
        public string Alias { get; set; }

        public int HitCount { get; set; }
        public UrlDto()
        {

        }
        public UrlDto(long id, string urlAdress, string alias, int hitCount)
        {
            this.Id = id;
            this.UrlAdress = urlAdress;
            this.Alias = alias;
            this.HitCount = hitCount;
        }
    }
}
