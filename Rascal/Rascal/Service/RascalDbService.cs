using Microsoft.EntityFrameworkCore;
using Rascal.DbRascal;
using Rascal.Entity;
using System;
using System.Linq;

namespace Rascal.Service
{
    public class RascalDbService : IRascalDbService
    {
        private readonly RascalDbContext rascalDb;

        public RascalDbService(RascalDbContext rascalDb)
        {
            this.rascalDb = rascalDb;
        }

        public void CreateApiKey(User user)
        {

            //var users = GetUser(user.UserName);
            //users.UserApiKey.apiKey = apikey;
            //var Appi = new UserApiKey() { apiKey = Apikey, User = user };
            rascalDb.Entry(user).State = EntityState.Modified;
            //rascalDb.UserApiKeys.Add(Appi);
            rascalDb.SaveChanges();
        }

        public void CreateUser(User userName)
        {
            rascalDb.Users.Add(userName);
            rascalDb.SaveChanges();
        }

        public User FindUser(string id)
        {
            return rascalDb.Users.Include(x => x.UserApiKey).FirstOrDefault(x => x.UserName == id);
        }

        public string GetApiKey(User user)
        {
            //var idUser = user.Id ;
            var api = rascalDb.UserApiKeys.FirstOrDefault(x => x.User == user);
            return api.apiKey;
        }

        public string GetApiKey(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string user)
        {
            return rascalDb.Users.FirstOrDefault(x => x.UserName == user);
        }

        public User GetUser(User User)
        {
            throw new NotImplementedException();
        }

        public void RemoveApiKey(User user)
        {
            var api = rascalDb.UserApiKeys.FirstOrDefault(x => x.User == user);
            rascalDb.Remove(api);
            rascalDb.SaveChanges();
        }
    }
}
