using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class ClaimsConfig:EntityTypeConfiguration<ClaimsEntity>
    {
        public ClaimsConfig()
        {
            // Primary Key
            HasKey(k => k.Id);

            // Property and Table Definition
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.Name).HasColumnName("Name").HasMaxLength(128).IsRequired();

            ToTable("AspNetClaims");
        }
    }
}