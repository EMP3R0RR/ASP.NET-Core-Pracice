using Microsoft.AspNetCore.Mvc;
using testapp1.Models;

namespace testapp1.Controllers
{
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.MTitle = "Student List";
            User s1 = new User()
            {
                Id = 1,
                Name = "S1",
                Address = "Dhaka",
                Email = "person1@gmail.com"

            };
            User s2 = new User()
            {
                Id = 2,
                Name = "S2",
                Address = "Dhaka",
                Email = "person2@gmail.com"

            };
            List<User> students = new List<User>();
            students.Add(s1);
            students.Add(s2);

            return View(students);
        }
    }
}

