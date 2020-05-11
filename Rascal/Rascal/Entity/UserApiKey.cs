namespace Rascal.Entity
{
    public class UserApiKey
    {
        public int Id { get; set; }
        public string apiKey { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
