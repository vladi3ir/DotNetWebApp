using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            {

                return View("Error", new ErrorViewModel() { Message = "password" });
            }

            var updateModel = new MainViewModel();
            updateModel.Name = model.Name.ToUpper();
            updateModel.LengthOfName = model.Name.Length;

            return View(updateModel);
        }
    }
}