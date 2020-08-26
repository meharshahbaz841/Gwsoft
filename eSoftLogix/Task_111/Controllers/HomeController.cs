using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Task_111.Context;
using Task_111.Models;

namespace Task_111.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data_Context _db;
        public HomeController(Data_Context db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControlAccountList()
        {

            return View ();
        }

        public IActionResult ChartAccountsList()
        {

            return View();
        }
            
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }






    }
}
