using Rascal.Models;

namespace Rascal.ViewModel
{
    public class CreateMessageViewModel
    {
        public Chanel Chanel { get; set; }

        public int Id { get; set; }
        public string Content { get; set; }
        public string channelSecret { get; set; }

    }
}
