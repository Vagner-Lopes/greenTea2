using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using greenTea.Models;

namespace greenTea.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<CardTable> CardTables { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
