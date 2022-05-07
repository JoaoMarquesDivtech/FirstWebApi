using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lib.Data;
using FirstWebApi.Entities;

namespace Lib.Data
{
    public class DataBaseContext : DbContext
    {
        public string strConnection { get; set; } = "Server=localhost;Database=WebAppDb; Uid=celinho;Pwd=59869887;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(strConnection, ServerVersion.AutoDetect(strConnection));
        }

        public DbSet<Livro> Livros { get; set; }




    } 
}
