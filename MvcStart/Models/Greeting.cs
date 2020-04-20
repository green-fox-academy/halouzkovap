namespace MvcStart.Models
{
    public class Greeting
    {


        public long Id { get; set; }
        public string Content { get; set; }
        public static int count { get; set; } = 0;
        public Greeting(string content)
        {
            count++;
            Id = count;
            Content = Content;
        }
        public Greeting()
        {
        }
    }

}
