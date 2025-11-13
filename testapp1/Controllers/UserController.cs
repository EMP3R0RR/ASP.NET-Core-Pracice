using Microsoft.AspNetCore.Mvc;
using testapp1.Models;
using testapp1.Data;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace testapp1.Controllers
{
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;
        private readonly UserDbContext _context;

        public UserController(UserDbContext context,ILogger<UserController> logger)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.MTitle = "User List";
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
            List<User> user = new List<User>();
            user.Add(s1);
            user.Add(s2);

            return View(user);
        }

        public IActionResult UserList()
        {
            ViewBag.MTitle = "User List";
            var user = _context.Users.ToList();
            return View(user);
        }
    }
}

