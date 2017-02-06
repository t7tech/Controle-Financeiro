using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class UserRolesConfig : EntityTypeConfiguration<UserRolesEntity>
    {
        public UserRolesConfig()
        {
            HasKey(k => new
            {
                k.UserId,
                k.RoleId
            });

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