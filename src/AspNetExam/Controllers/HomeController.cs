using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int count)
        {
            var r = new Random();
            this.ViewData["results"] =
                Enumerable.Range(0, count).
                Select(index => r.Next()).
                ToArray();
            return this.View();
        }
    }
}
