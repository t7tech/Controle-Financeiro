﻿using System.Data.Entity;
using T7.ControleFinanceiro.Domain.Entities;
using T7.ControleFinanceiro.Infra.Data.EntityConfig;

namespace T7.ControleFinanceiro.Infra.Data.Context
{
    public class IdentityIsolationContext : DbContext
    {
        #region ctor

        public IdentityIsolationContext()
            : base("DefaultConnection") { }

        #endregion

        #region DbSet

        public DbSet<UserEntity> Usuarios { get; set; }
        public DbSet<RoleEntity> Role { get; set; }
        public DbSet<UserRolesEntity> UserRoles { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new RoleConfig());
            modelBuilder.Configurations.Add(new UserRolesConfig());

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}