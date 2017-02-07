using System.Data.Entity;
using T7.ControleFinanceiro.Domain.Entities.Account;
using T7.ControleFinanceiro.Infra.Data.EntityConfig.Account;

namespace T7.ControleFinanceiro.Infra.Data.Context
{
    public class IdentityDbContext : DbContext
    {
        #region ctor

        public IdentityDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<IdentityDbContext>(null);
        }

        #endregion

        #region DbSet

        public DbSet<UserEntity> User { get; set; }
        public DbSet<RoleEntity> Role { get; set; }
        public DbSet<UserRolesEntity> UserRoles { get; set; }
        public DbSet<ClaimsEntity> Claims { get; set; }
        public DbSet<UserClaimsEntity> UserClaims { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new RoleConfig());
            modelBuilder.Configurations.Add(new UserRolesConfig());
            modelBuilder.Configurations.Add(new ClaimsConfig());
            modelBuilder.Configurations.Add(new UserClaimsConfig());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}