using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsAnalyzer.Services.Contracts;
using SportsAnalyzer.Web.ViewModels;

namespace SportsAnalyzer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValidatorService validatorService;

        public HomeController(IValidatorService validatorService)
        {
            this.validatorService = validatorService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            this.validatorService.CheckIfStringIsNullOrEmpty(this.JustATestOnLocalFunctions("Nikodim"));

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string JustATestOnLocalFunctions(string name) => $"My name is {name}";
    }
}
