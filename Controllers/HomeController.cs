using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        //My different views for when the website is pulled up and when they jump from page to page.
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("gradeCalc")]
        public IActionResult gradeCalc()
        {
            return View();
        }

        [HttpPost("gradeCalc")]
        public IActionResult gradeCalc(gradeCalc model)
        {
            return View();
        }
    }
}
