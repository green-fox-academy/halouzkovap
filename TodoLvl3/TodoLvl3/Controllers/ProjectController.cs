using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoLvl3.Entity;
using TodoLvl3.Services;
using TodoLvl3.ViewModel;

namespace TodoLvl3.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ITodoService todoService;

        public ProjectController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        // GET: Project
        public ActionResult Index()
        {
            var project = todoService.Projects();
            return View(project);
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            var project = todoService.GetProject(id);
            return View(project);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            var createProject = new CreateProjectViewModel();
            var mentor = todoService.GetMentors().Where(x => x.Project == null).ToList();
            var task = todoService.GetTasks().Where(x => x.Project == null).ToList();
            createProject.Tasks = task;
            createProject.Mentors = mentor;
            return View(createProject);
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(CreateProjectViewModel createProject)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var project = new Project(createProject.Name, createProject.Description, createProject.DueDate);
                    todoService.CreateProject(project);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            var project = todoService.GetProject(id);
            var mentor = todoService.GetMentors().Where(x => x.Project == null).ToList();
            var task = todoService.GetTasks().Where(x => x.Project == null).ToList();
            var model = new EditProjectViewModel() { Mentors = mentor, Project = project, Tasks = task };
            return View(model);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditProjectViewModel editProject)
        {
            try
            {
                var project = todoService.GetProject(id);
                // TODO: Add update logic here
                todoService.UpdateProject(project);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}