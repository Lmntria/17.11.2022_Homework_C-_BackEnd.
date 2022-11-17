using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            TeamVm vm = new TeamVm
            {
                Teams = Data.Teams
            };
            return View(vm);
        }
    }
}

