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
        public IActionResult CreateBankAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBankAccount(BankAccount bankAccount)
        {


            if (ModelState.IsValid)
            {
                _bankServis.CreateBankAccount(bankAccount);

                return RedirectToAction("CheckoutComplete");
            }
            return View(bankAccount);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutMessage = "New Account created";
            return View();
        }
        public IActionResult RaiseBalance()
        {
            _bankServis.RaiseBalance();
            return RedirectToAction("Index");

        }
        public IActionResult DecreaseBalance()
        {
            _bankServis.DecreaseBalance();
            return RedirectToAction("Index");

        }
        public IActionResult TakeThemAll()
        {
            _bankServis.TakeThemALL();
            return RedirectToAction("Index");

        }
    }
}