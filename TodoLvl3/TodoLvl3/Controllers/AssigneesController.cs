using Microsoft.AspNetCore.Mvc;
using TodoLvl3.Entity;
using TodoLvl3.Services;
using TodoLvl3.ViewModel;

namespace TodoLvl3.Controllers
{
    public class AssigneesController : Controller
    {
        private readonly ITodoService todoService;

        public AssigneesController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        // GET: Assignees
        public IActionResult Index()
        {
            var model = todoService.GetAssignees();
            return View(model);
        }

        // GET: Assignees/Details/5
        public IActionResult Details(int id)
        {
            var assignee = todoService.GetAssigne(id);
            if (assignee == null)
            {
                return NotFound();
            }

            return View(assignee);
        }

        // GET: Assignees/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Email")] Assignee assignee)
        {
            if (ModelState.IsValid)
            {
                todoService.CreateAssignee(assignee);

                return RedirectToAction("Index");
            }
            return View(assignee);
        }

        // GET: Assignees/Edit/5
        public IActionResult Edit(int id)
        {
            var assignee = todoService.GetAssigne(id);
            if (assignee == null)
            {
                return NotFound();
            }
            return View(assignee);
        }

        // POST: Assignees/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, EditAssignee assignee)
        {
            var assigne = todoService.FindAssignees(id);
            if (assigne == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                assigne.Name = assignee.Name;
                assigne.Email = assignee.Email;
                todoService.UpdateAssignee(assigne);

                return RedirectToAction("Index");
            }
            return View(assignee);
        }

        //// GET: Assignees/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var assignee = await _context.Assignees
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (assignee == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(assignee);
        //}

        //// POST: Assignees/Delete/5
        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var assignee = await _context.Assignees.FindAsync(id);
        //    _context.Assignees.Remove(assignee);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}


    }
}
