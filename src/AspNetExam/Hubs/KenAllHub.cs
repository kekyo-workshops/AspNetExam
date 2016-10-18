using AspNetExam.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetExam.Hubs
{
    [HubName("ken_all_hub")]
    public class KenAllHub : Hub
    {
        private readonly IHostingEnvironment _hosting;

        public KenAllHub(IHostingEnvironment hosting)
        {
            _hosting = hosting;
        }

        public async Task<x_ken_all[]> GetByZipCode(int zipCode)
        {
            // 郵便番号辞書から検索する
            var records = await x_ken_all_accessor.FetchByNewZipCodeAsync(
                _hosting.WebRootPath, zipCode);
            return records;
        }
    }
}
