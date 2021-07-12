using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestIbragimov.DAL;
using TestIbragimov.Models;

namespace TestIbragimov.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
 
            {
                var context = new DataContext();
                ViewBag.List = context.Users.Where(u => u.Name != "system" && !string.IsNullOrEmpty(u.About));
                return View();
            }
        }

    
        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Create User");
            }
            var context = new DataContext();
            context.Users.Add(user);
            context.SaveChanges();
            return Redirect("~/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
