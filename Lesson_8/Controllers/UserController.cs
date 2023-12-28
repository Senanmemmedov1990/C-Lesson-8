using Microsoft.AspNetCore.Mvc;

namespace Lesson_8.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(User);
        }
    }
}
