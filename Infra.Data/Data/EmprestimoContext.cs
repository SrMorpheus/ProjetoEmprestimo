using Microsoft.EntityFrameworkCore;
using Domain.models;
using Microsoft.EntityFrameworkCore.Migrations;
namespace Infra.Data.Data
{
    public class EmprestimoContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; } 
        public DbSet<HistoricoEmail> HistoricoEmails { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<TipoUtilizador> TipoUtilizadores { get; set; }
        public DbSet<UltilizadorEmprestimo> UltilizadorEmprestimos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }


        public EmprestimoContext(DbContextOptions<EmprestimoContext> options): base(options)
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

    }
}
