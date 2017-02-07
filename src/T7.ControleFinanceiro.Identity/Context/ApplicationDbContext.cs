using System;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using T7.ControleFinanceiro.Domain.Entities.Account;
using System.Data.Entity;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}