using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Banco
{


    public class EscolaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=MeuBanco;user=root;password=",
                        new MySqlServerVersion("10.4.28-MariaDB"));
        }
    }
}
