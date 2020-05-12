namespace Rascal.Models
{
    public class Author
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        private string avatarUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmyloview.cz%2Ffototapeta-lidske-man-person-avatar-uzivatelsky-profil-ikon-vektor-ilustrace-c-4D330DF&psig=AOvVaw0aiXwLnaZrmQqwoStwjF4J&ust=1589351730053000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCJDSqNzarekCFQAAAAAdAAAAABAI";
        public string AvatarUrl
        {
            get => avatarUrl;
            set
            {
                if (value == null || value == "url to avatar image")
                {
                    avatarUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmyloview.cz%2Ffototapeta-lidske-man-person-avatar-uzivatelsky-profil-ikon-vektor-ilustrace-c-4D330DF&psig=AOvVaw0aiXwLnaZrmQqwoStwjF4J&ust=1589351730053000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCJDSqNzarekCFQAAAAAdAAAAABAI";
                }
                else
                {
                    avatarUrl = value;
                }
            }
        }
    }
}