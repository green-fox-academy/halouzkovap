using Rascal.Entity;
using System.Collections.Generic;

namespace Rascal.Service
{
    public interface IRascalDbService
    {
        User GetUser(string id);
        User FindUser(string id);
        User GetUser(User User);
        string GetApiKey(User user);
        string GetApiKey(int id);
        void RemoveApiKey(User user);
        void CreateUser(User User);
        void CreateApiKey(User user);
        void CreateChannel(MyChannel channel);
        List<MyChannel> GetMyChannels();
        MyChannel FindChannel(int id);
    }
}
