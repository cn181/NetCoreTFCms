using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreTFCms;
using NetCoreTFCms.Models;

namespace NetCoreTFCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {


        // GET: Home

        public IActionResult Index()
        {
            return View();
        }

        // GET: Center
        public IActionResult Center()
        {
            return View();
        }
    }
}
