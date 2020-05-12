namespace Rascal.ViewModel
{
    public class GetMessageViewModel
    {
        public int ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public int Count { get; set; } = 100;
    }
}
