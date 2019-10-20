using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment5a.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Welcome(MainViewModel model)
        {
            if (!ModelState.IsValid)
            // if (!userInfo.Name.Equals("Rob", StringComparison.OrdinalIgnoreCase))
            {

                return View("Error", new ErrorViewModel() { Message = "Invalid name we are looking for you're boy rob" });
            }

            return View(model);
        }
    }
}