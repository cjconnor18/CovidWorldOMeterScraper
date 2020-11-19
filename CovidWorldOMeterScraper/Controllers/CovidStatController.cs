using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidWorldOMeterScraper.Data;
using Microsoft.AspNetCore.Mvc;

namespace CovidWorldOMeterScraper.Controllers
{
    public class CovidStatController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.covidStats = CovidStatData.GetAll();
            return View();
        }
    }
}
