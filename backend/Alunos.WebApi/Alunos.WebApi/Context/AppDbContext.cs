using Alunos.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.WebApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Maria da Penha",
                    Email = "mra.penha@gmail.com",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Jose Fernandes",
                    Email = "jse.fernandes@gmail.com",
                    Idade = 32
                }
            );
        }
    }
}
