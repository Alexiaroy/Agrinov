using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgriNov.Controllers
{
       public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LegalNotice()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}