using Microsoft.AspNetCore.Mvc;
using MvcStart.Models;
using MvcStart.ViewModels;

namespace MvcStart.Controllers
{
    public class HellosController : Controller
    {
        private readonly IHiCollection _hiCollection;

        public HellosController(IHiCollection hiCollection)
        {
            _hiCollection = hiCollection;
        }

        public IActionResult List()
        {
            HellosListViewModel hellosListViewModel = new HellosListViewModel();
            hellosListViewModel.hellos = _hiCollection.hellow;

            return View(hellosListViewModel);
        }
        public IActionResult Hello(int id)
        {

            var hello = _hiCollection.GetHello(id);
            return View(hello);
        }
    }
}