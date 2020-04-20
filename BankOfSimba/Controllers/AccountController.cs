using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class AccountController : Controller
    {
        private readonly IBankServis _bankServis;

        public AccountController(IBankServis bankServis)
        {
            _bankServis = bankServis;
        }
        public IActionResult Index()
        {
            var account = _bankServis.GettAll();
            return View(new BankAccountViewModel
            {
                Account = account
            }); ;
        }
    }
}