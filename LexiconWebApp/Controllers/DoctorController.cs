using LexiconWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconWebApp.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            ViewBag.Title = "Check Your temperature";
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(float temperature)
        {
            ViewBag.message = FeverCheckerModel.Fever(temperature);
            return View();
        }
    }
}
