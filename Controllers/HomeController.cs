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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Fanmail")]
        public IActionResult gradeCalc()
        {
            return View();
        }

        [HttpPost("FanMail")]
        public IActionResult gradeCalc(gradeCalc model)
        {
            return View();
        }
    }
}
