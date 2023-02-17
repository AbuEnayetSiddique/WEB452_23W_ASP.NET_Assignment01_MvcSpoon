using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSpoon.Controllers
{
    public class SpoonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
