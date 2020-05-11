using Rascal.Models;

namespace Rascal.ViewModel
{
    public class CreateMessageViewModel
    {
        public int ChannelId { get; set; }
        public int ChannelSecret { get; set; }
        public string Content { get; set; }
        Author Author { get; set; }
    }
}
