using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
           
            var user = new User("Сармат", "Макиев", "MAK@MAIL.ru");

            return View(user);
        }
    }
}