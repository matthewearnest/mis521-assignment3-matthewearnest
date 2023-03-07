using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTest.Models;

namespace MyTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyTest.Models.Actors> Actors { get; set; }
        public DbSet<MyTest.Models.Movies> Movies { get; set; }
        public DbSet<MyTest.Models.MoviesActors> MoviesActors { get; set; }
    }
}