using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Urunler()
        {
            return View();
        }
        public IActionResult Sogutma()
        {
            return View();
        }
        public IActionResult Isıtma()
        {
            return View();
        }
    }
}
