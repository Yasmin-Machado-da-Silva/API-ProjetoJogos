using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Contexts
{
    public class ProjetoJogosContext : DbContext
    {
        public ProjetoJogosContext(){}
        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options): base(options)
        {
            
        }

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-EUMC23F\\SQLEXPRESS; Database = ProjetoJogos ; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
            }
        }
    }
}