using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;

namespace AspNetExam.Models
{
    public class x_ken_all_context : DbContext
    {
        private readonly string _path;

        public x_ken_all_context(string basePath)
        {
            _path = Path.Combine(basePath, "x_ken_all.sqlite");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqliteConnectionStringBuilder { DataSource = _path };
            optionsBuilder.UseSqlite(new SqliteConnection(builder.ToString()));
        }

        public DbSet<x_ken_all> x_ken_alls { get; set; }
    }
}
