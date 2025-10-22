using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using MySqlConnector;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        // Construtores
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // String de conexão para MySQL
                string connectionString = "Server=localhost;User=dev_mateus;Password=mf58362105;Database=ExoApi";

                // Configura o MySQL com a versão do servidor
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }
        
    // DbSet para os modelos
    public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    }
}

// Observação: O material original colocava um '}' a mais no final da página 6,
// mas o código acima está estruturalmente correto.