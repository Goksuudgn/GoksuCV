using GoksuCV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoksuCV.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Projects()
        {
            return View("Projects");
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }


    }
}
