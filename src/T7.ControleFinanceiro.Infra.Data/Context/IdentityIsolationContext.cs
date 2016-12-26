using System.Data.Entity;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Infra.Data.EntityConfig;

namespace T7.ControleFinanceiro.Infra.Data.Context
{
    public class IdentityIsolationContext : DbContext
    {
        public IdentityIsolationContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}