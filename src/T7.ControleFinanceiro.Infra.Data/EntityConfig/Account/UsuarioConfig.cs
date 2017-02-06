﻿using System.Data.Entity.ModelConfiguration;
using T7.ControleFinanceiro.Domain.Entities.Account;

namespace T7.ControleFinanceiro.Infra.Data.EntityConfig.Account
{
    public class UsuarioConfig : EntityTypeConfiguration<UserEntity>
    {
        public UsuarioConfig()
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

            ToTable("AspNetUsers");
        }
    }
}