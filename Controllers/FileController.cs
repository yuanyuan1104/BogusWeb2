using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace lab.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            string[] file = Directory.GetFiles("./TextFiles");
            ViewData["files"] = file;
            return View();
        }
        public IActionResult Content()
        {
            return View();
        }
    }
}