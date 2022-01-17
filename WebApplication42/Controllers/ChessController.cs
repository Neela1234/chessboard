using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication42.Controllers
{
    public class ChessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
