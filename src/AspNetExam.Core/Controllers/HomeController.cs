using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetExam.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hosting;

        public HomeController(IHostingEnvironment hosting)
        {
            _hosting = hosting;
        }

        public async Task<IActionResult> Index(int zipCode)
        {
            // 郵便番号辞書から検索する
            var records = await x_ken_all_accessor.FetchByNewZipCodeAsync(
                _hosting.WebRootPath, zipCode);

            // 結果をビューに転送
            return this.View(new IndexResults
            { Title = "ASP.NET MVC Results", Records = records });
        }
    }
}
