using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.DbModels;
using Bookish.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _checkout;

        public CheckoutController (ICheckoutService checkoutService)
        {
            _checkout = checkoutService;
        }

        public IActionResult All()
        {
            var checkoutTable = _checkout.GenerateCheckoutList();
            return View(checkoutTable);
        }
    }
}
