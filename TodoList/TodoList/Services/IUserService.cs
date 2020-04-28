using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUser();
        IEnumerable<User> FindUser(string name);
        User DetailUser(int id);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void CreateUser(User user);
        void AddNewTaskToUser(Todo todo);
    }
}
