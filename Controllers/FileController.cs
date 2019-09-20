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
            var path = Path.Combine(_hostingEnvironment.ContentRootPath, "TextFiles");
            // Console.WriteLine(path);
            string[] files = Directory.GetFiles(path);
            string[] filenames = new string[files.Length];
            for(int i = 0; i < files.Length; i ++){
                filenames[i] = Path.GetFileName(files[i]);
            }
            // string[] filename = Path.GetFileName(file);
            ViewData["files"] = filenames;
            return View();
        }
        public IActionResult Content(string id)
        {
             var path = Path.Combine(_hostingEnvironment.ContentRootPath, "TextFiles", id);
            // Console.WriteLine(path);
            // string[] files = Directory.GetFiles(path);
            // string[] filenames = new string[files.Length];
            // for(int i = 0; i < files.Length; i ++){
                // filenames[i] = Path.GetFileName(files[i]);
            // }
            var filecontent = System.IO.File.ReadAllText(path);
            ViewData["filecontents"] = filecontent;
            return View();
        }
    }
}