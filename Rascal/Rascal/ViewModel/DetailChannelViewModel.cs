using Rascal.Entity;
using System.Collections.Generic;

namespace Rascal.ViewModel
{
    public class DetailChannelViewModel
    {
        public List<Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging.Message> ListMessage { get; internal set; }
        public MyChannel Channel { get; internal set; }
        public List<Models.Message> ListMessages { get; internal set; }
        public int Id { get; internal set; }
        public List<MyChannel> ChannelsDb { get; internal set; }
    }
}
