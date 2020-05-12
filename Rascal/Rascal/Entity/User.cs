using System.Collections.Generic;

namespace Rascal.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public UserApiKey UserApiKey { get; set; }
        public List<MyChannel> MyChannels { get; set; }
    }
}
