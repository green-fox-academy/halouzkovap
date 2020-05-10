using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UpdateTodo.Entitiy;
using UpdateTodo.Services;
using UpdateTodo.ViewModels;

namespace UpdateTodo.Controllers
{
    public class TodoController : Controller
    {
        private ITodoServise todoService;

        public TodoController(ITodoServise todoService)
        {
            this.todoService = todoService;
        }
        // GET: Todo
        public ActionResult Index()
        {
            var model = todoService.GetTodos();
            return View(model);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            var model = todoService.FindTodo(id);
            return View(model);
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            //drop dow menu
            CreateTodoViewModel model = new CreateTodoViewModel();
            var assinge = todoService.GetAssignees().ToList();
            model.Assignees = new List<Assignee>();
            foreach (var item in assinge)
            {
                model.Assignees.Add(item);
            }


            return View(model);
        }
        [AllowAnonymous]
        // POST: Todo/Create
        [HttpPost]
        public ActionResult Create(CreateTodoViewModel createTodoView)
        {

            if (ModelState.IsValid)
            {
                var asigne = todoService.FindAssigne(createTodoView.ChoosenId);
                var todo = new Todo()
                {
                    Title = createTodoView.Title,
                    Description = createTodoView.Description,
                    IsUrgent = createTodoView.IsUrgent,
                    DueDate = createTodoView.DueDate,
                    AssigneeId = createTodoView.ChoosenId

                };
                todoService.CreateTodo(todo);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Crete");
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {

            var todo = todoService.FindTodo(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);


        }

        // POST: Todo/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind]Todo todo)
        {
            if (ModelState.IsValid)
            {
                todoService.UpdateTodo(todo);
                return RedirectToAction("Index");
            }
            return View(todo);

        }

        // GET: Todo/Delete/5
        [HttpGet]

        public ActionResult Delete(int id)
        {
            var todo = todoService.FindTodo(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        // POST: Todo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                todoService.DeleteTodo(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}