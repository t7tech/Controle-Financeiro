using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7.ControleFinanceiro.Domain.Entities;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig
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