using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig
{
    public class UserRolesConfig : EntityTypeConfiguration<UserRolesEntity>
    {
        public UserRolesConfig()
        {
            Property(p => p.RoleId)
                .IsRequired()
                .HasMaxLength(128);

            Property(p => p.UserId)
                .IsRequired()
                .HasMaxLength(128);

            ToTable("AspNetUserRoles");
        }
    }
}