using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class UserClaimsConfig : EntityTypeConfiguration<UserClaimsEntity>
    {
        public UserClaimsConfig()
        {
            // Primary Key
            HasKey(k => k.Id);

            // Table and Column Definition
            Property(p => p.Id).HasColumnName("Id").IsRequired();
            Property(p => p.UserId).HasColumnName("UserId").HasMaxLength(128).IsRequired();
            Property(p => p.ClaimType).HasColumnName("ClaimType");
            Property(p => p.ClaimValue).HasColumnName("ClaimValue");

            ToTable("AspNetUserClaims");
        }
    }
}