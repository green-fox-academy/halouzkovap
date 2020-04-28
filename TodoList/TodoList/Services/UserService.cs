using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TodoList.Db;
using TodoList.Models;

namespace TodoList.Services
{
    public class UserService : IUserService
    {
        private readonly TodoListDbContext todoListDb;

        public UserService(TodoListDbContext todoListDb)
        {
            this.todoListDb = todoListDb;
        }

        public void AddNewTaskToUser(Todo todo)
        {

            todoListDb.Todos.Add(todo);
            todoListDb.SaveChanges();
        }

        public void CreateUser(User user)
        {
            todoListDb.Add(user);
            todoListDb.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = todoListDb.Users.Find(id);
            todoListDb.Remove(user);
            todoListDb.SaveChanges();

        }

        public User DetailUser(int id)
        {
            return todoListDb.Users.Include(t => t.Todos).FirstOrDefault(u => u.Id == id);

        }

        public IEnumerable<User> FindUser(string name)
        {
            return todoListDb.Users.Where(t => t.Name.Contains(name));

        }

        public IEnumerable<User> GetUser()
        {
            return todoListDb.Users.Include(t => t.Todos);
        }

        public void UpdateUser(User user)
        {
            todoListDb.Entry(user).State = EntityState.Added;
            todoListDb.SaveChanges();
        }
    }
}
