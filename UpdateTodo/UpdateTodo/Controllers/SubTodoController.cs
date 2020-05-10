using Microsoft.AspNetCore.Mvc;
using UpdateTodo.Entitiy;
using UpdateTodo.Services;
using UpdateTodo.ViewModels;

namespace UpdateTodo.Controllers
{
    public class SubTodoController : Controller
    {
        private readonly ITodoServise todoServise;

        public SubTodoController(ITodoServise todoServise)
        {
            this.todoServise = todoServise;
        }


        // GET: SubTodo/Details/5
        public ActionResult Details(int id)
        {
            var todos = todoServise.GetTodo(id);

            return View(todos);
        }


        public ActionResult CreateSubTodo(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSubTodo(int id, CreateSubTodoViewModel createSubTodo)
        {
            if (ModelState.IsValid)
            {
                var subTodo = new SubTodo()
                {
                    Title = createSubTodo.Title,
                    Description = createSubTodo.Description,
                    IsDone = createSubTodo.IsDone,
                    IsUrgent = createSubTodo.IsUrgent,
                    TodoId = id


                };

                todoServise.CreateSubTodo(subTodo);
                return RedirectToAction("Details", "todo", id);
            }
            return View("CreateSubTodo");
        }



    }
}