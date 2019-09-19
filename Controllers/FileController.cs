using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace lab.Controllers
{
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            // string webRootPath = _hostingEnvironment.WebRootPath;
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "./TextFiles");
            string[] file = Directory.GetFiles(path);
            // string[] filename = Path.GetFileName(file);
            ViewData["files"] = file;
            return View();
        }
        public IActionResult Content()
        {
            return View();
        }
    }
}