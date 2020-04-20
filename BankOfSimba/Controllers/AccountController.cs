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

        //[HttpPost]
        //public IActionResult Checkout(Order order)
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;

        //    if (_shoppingCart.ShoppingCartItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", "Your cart is empty, add some pies first");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _orderRepository.CreateOrder(order);
        //        _shoppingCart.ClearCart();
        //        return RedirectToAction("CheckoutComplete");
        //    }
        //    return View(order);
        //}
    }
}