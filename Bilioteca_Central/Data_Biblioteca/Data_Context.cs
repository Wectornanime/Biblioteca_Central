using Bilioteca_Central.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca_Central.Data_Biblioteca
{
    public class Data_Context : DbContext
    {

        public Data_Context(DbContextOptions<Data_Context> options) : base(options)
        {

        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Multa> Multas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livros");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Emprestimo>().ToTable("Emprestimos");
            modelBuilder.Entity<Multa>().ToTable("Multas");
        }

    }
}
