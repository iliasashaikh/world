using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace world.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_env);
        }

        public IActionResult View(string country)
        {
            throw new NotImplementedException();
        }

        // india/map
        public IActionResult Map(string country)
        {
            throw new NotImplementedException();
        }
    }
}
