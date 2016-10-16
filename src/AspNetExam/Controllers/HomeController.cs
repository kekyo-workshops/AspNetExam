using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int num)
        {
            this.ViewData["result"] = num + 1;
            return this.View();
        }
    }
}
