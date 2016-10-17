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

        public IActionResult Index(int zipCode)
        {
            // 7桁文字列に変換
            var zipCodeString = string.Format("{0:D7}", zipCode);

            using (var context = new x_ken_all_context(_hosting.WebRootPath))
            {
                // 郵便番号が一致するレコードを抽出
                var q =
                    from record in context.x_ken_alls
                    where record.NewZipCode == zipCodeString
                    select record;

                // （固定化）
                return this.View(q.ToArray());
            }
        }
    }
}
