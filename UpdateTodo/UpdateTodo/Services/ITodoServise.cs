using System.Collections.Generic;
using UpdateTodo.Entitiy;

namespace UpdateTodo.Services
{
    public interface ITodoServise
    {
        User GetByUsernameAndPassword(string Username, string Password);
        Todo GetTodo(int id);
        SubTodo GetSubTodo(int id);
        IEnumerable<Todo> GetTodos();
        IEnumerable<Todo> GetTodosForAssignee(int id);
        IEnumerable<Assignee> GetAssignees();
        List<Assignee> GetAssigneesToList();
        Assignee FindAssigne(int id);
        Todo FindTodo(int id);
        SubTodo FindSubtodo(int id);
        IEnumerable<SubTodo> GetSubToto(int todoId);
        public void CreateTodo(Todo todo);
        public void UpdateTodo(Todo todo);
        public void UpdateSubTodo(SubTodo todo);
        public void CreateAssignee(Assignee assignee);
        public void CreateUser(User user);
        public void CreateSubTodo(SubTodo subTodo);
        public void DeleteTodo(int id);
        public void DeleteSubTodo(int id);
    }
}
