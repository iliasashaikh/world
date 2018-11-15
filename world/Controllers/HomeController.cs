using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using world.Models;

namespace world.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult All()
        {
            List<Country> countryList = GetAllCountries();

            //return new ObjectResult(countryList);

            return View(countryList);
        }

        private List<Country> GetAllCountries()
        {
            var contentRoot = _env.ContentRootFileProvider;
            var countriesFi = contentRoot.GetFileInfo("Data/countries.json");
            var countriesStream = countriesFi.CreateReadStream();
            var countries = new StreamReader(countriesStream).ReadToEnd();

            var countryList = JsonConvert.DeserializeObject<List<Country>>(countries);
            return countryList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var countries = GetAllCountries();
            Country.CountryNames = countries.Select(c => c.Name).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            var countries = GetAllCountries();
            var country = countries.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.CurrentCultureIgnoreCase));
            Country.CountryNames = countries.Select(c => c.Name).ToList();
            return View(country);
        }

        public IActionResult Map(string country)
        {
            throw new NotImplementedException();
        }
    }
}
