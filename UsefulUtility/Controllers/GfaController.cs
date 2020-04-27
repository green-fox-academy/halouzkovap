using Microsoft.AspNetCore.Mvc;
using UsefulUtility.Services;
using UsefulUtility.ViewModels;

namespace UsefulUtility.Controllers
{
    public class GfaController : Controller
    {
        private readonly IStudentService studentService;

        public GfaController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public IActionResult List()
        {
            var students = studentService.FindAll();
            return View(new StudentViewModel
            {
                Students = students
            });
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string name)
        {
            studentService.Save(name);
            studentService.SaveToTxt(name);
            return RedirectToAction("List");
        }
    }
}