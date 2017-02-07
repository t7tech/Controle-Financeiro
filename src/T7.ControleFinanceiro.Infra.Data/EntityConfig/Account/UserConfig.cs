using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class UserConfig : EntityTypeConfiguration<UserEntity>
    {
        public UserConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.DateBirth)
                .IsRequired();

            ToTable("AspNetUsers");
        }
    }
}