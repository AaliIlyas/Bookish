using Bookish.Models;
using Bookish.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookish.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _checkout;

        public CheckoutController (ICheckoutService checkoutService)
        {
            _checkout = checkoutService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var checkoutTable = _checkout.GenerateCheckoutList();
            return View(checkoutTable);
        }

        [HttpGet]
        public IActionResult Borrow(int id)
        {
            var checkout = _checkout.GetIndividualCheckout(id);
            return View(checkout);
        }

        [HttpPost]
        public IActionResult SubmitEdit(SingleCheckoutViewModel singleCheckoutViewModel)
        {
            _checkout.EditIndividualCheckout(singleCheckoutViewModel);
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public IActionResult DeleteEntry(SingleCheckoutViewModel entry)
        {
            _checkout.DeleteEntry(entry);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCheckout(NewCheckoutViewModel newCheckoutViewModel)
        {
            _checkout.AddNewCheckedOut(newCheckoutViewModel);
            return RedirectToAction(nameof(All));
        }
    }
}
