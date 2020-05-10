using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpdateTodo.Database;
using UpdateTodo.Entitiy;

namespace UpdateTodo.Services
{
    public class TodoServise : ITodoServise
    {
        private readonly AppDbContext appDb;

        public TodoServise(AppDbContext appDb)
        {
            this.appDb = appDb;
        }

        public void CreateAssignee(Assignee assignee)
        {
            appDb.Assignees.Add(assignee);
            appDb.SaveChanges();
        }

        public void CreateSubTodo(SubTodo subTodo)
        {
            appDb.SubTodos.Add(subTodo);
            appDb.SaveChanges();
        }

        public void CreateTodo(Todo todo)
        {
            appDb.Todos.Add(todo);
            appDb.SaveChanges();
        }

        public void CreateUser(User user)
        {
            appDb.Users.Add(user);
            appDb.SaveChanges();
        }

        public void DeleteSubTodo(int id)
        {
            var Subtotos = appDb.SubTodos.Find(id);
            appDb.SubTodos.Remove(Subtotos);
            appDb.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            var todos = appDb.Todos.Find(id);
            appDb.Todos.Remove(todos);
            appDb.SaveChanges();
        }

        public Assignee FindAssigne(int id)
        {
            return appDb.Assignees.Find(id);
        }

        public SubTodo FindSubtodo(int id)
        {
            return appDb.SubTodos.Find(id);
        }

        public Todo FindTodo(int id)
        {
            return appDb.Todos.Include(x => x.SubTodos).Include(x => x.Assignee).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Assignee> GetAssignees()
        {
            return appDb.Assignees;
        }

        public List<Assignee> GetAssigneesToList()
        {
            return appDb.Assignees.ToList();
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            return appDb.Users.SingleOrDefault(x => x.Name == username && x.Password == password);
        }

        public SubTodo GetSubTodo(int id)
        {
            return appDb.SubTodos.Find(id);

        }

        public IEnumerable<SubTodo> GetSubToto(int todoId)
        {
            return appDb.SubTodos.Where(x => x.TodoId == todoId);
        }

        public Todo GetTodo(int id)
        {
            return appDb.Todos.Include(x => x.SubTodos).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Todo> GetTodos()
        {
            return appDb.Todos.Include(t => t.SubTodos).Include(x => x.Assignee);
        }

        public IEnumerable<Todo> GetTodosForAssignee(int id)
        {
            return appDb.Todos.Where(x => x.AssigneeId == id);
        }

        public void UpdateSubTodo(SubTodo todo)
        {
            appDb.SaveChanges();
        }

        public void UpdateTodo(Todo todo)
        {
            appDb.Entry(todo).State = EntityState.Modified;
            appDb.SaveChanges();

        }
    }
}
