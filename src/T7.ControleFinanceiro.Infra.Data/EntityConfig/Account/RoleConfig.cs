using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class RoleConfig : EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig()
        {
            HasKey(k => k.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(256);

            ToTable("AspNetRoles");
        }
    }
}