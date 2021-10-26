using Actividad1.MODELO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.DataContext
{
    class PostsDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CH99N01;Initial Catalog=Actividad1;Integrated Security=True");
        }
        public PostsDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}
