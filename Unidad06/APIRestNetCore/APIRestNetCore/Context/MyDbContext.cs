using Microsoft.EntityFrameworkCore;
using APIRestNetCore.Models;

namespace APIRestNetCore.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
