using Rascal.Entity;

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
    }
}
