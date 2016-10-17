using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetExam.Models
{
    public static class x_ken_all_accessor
    {
        public static async Task<x_ken_all[]>
            FetchByNewZipCodeAsync(string path, int zipCode)
        {
            // 7桁文字列に変換
            var zipCodeString = string.Format("{0:D7}", zipCode);

            using (var context = new x_ken_all_context(path))
            {
                // 郵便番号が一致するレコードを抽出
                var q =
                    from record in context.x_ken_alls
                    where record.NewZipCode == zipCodeString
                    select record;

                // （固定化）
                return await q.ToArrayAsync();
            }
        }
    }
}
