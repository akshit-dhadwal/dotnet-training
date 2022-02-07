using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using user_validation_form.Models;

namespace user_validation_form.Controllers
{
    public class UserRegistrationController1 : Controller
    {
        private readonly ApplicationUserClass _auc;

        public UserRegistrationController1(ApplicationUserClass auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
           //if( ModelState.IsValid == true)
           // {
           //     ViewBag.message = "succesfully registered";
           // }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The User is" + uc.Username + "is saved succesfully...";
            return View();

        }
    }
}
