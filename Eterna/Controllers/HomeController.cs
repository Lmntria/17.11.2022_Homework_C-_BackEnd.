using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eterna.ViewModels;
using Eterna.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm
            {
                Services = Data.Services,
                Features=Data.Features,
                Slides=Data.Slides
                
            };
            return View(vm);
        }
    }
}

