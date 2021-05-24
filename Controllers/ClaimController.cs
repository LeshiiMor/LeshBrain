using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeshBrain.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
