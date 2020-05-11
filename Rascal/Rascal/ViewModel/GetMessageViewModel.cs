namespace Rascal.ViewModel
{
    public class GetMessageViewModel
    {
        public int ChannelId { get; set; }
        public int ChannelSecret { get; set; }
        public int Count { get; set; } = 10;
    }
}
