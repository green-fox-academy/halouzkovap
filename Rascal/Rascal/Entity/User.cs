namespace Rascal.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public UserApiKey UserApiKey { get; set; }
    }
}
