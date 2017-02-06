using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Context;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;
using T7.ControleFinanceiro.Infra.Data.Repository.Account;
using T7.ControleFinanceiro.Service.Account;

namespace T7.ControleFinanceiro.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();

            #region Service

            container.RegisterPerWebRequest<IUserService, UserService>();
            container.RegisterPerWebRequest<IRoleService, RoleService>();
            container.RegisterPerWebRequest<IUserRolesService, UserRolesService>();

            #endregion

            #region Repository

            container.RegisterPerWebRequest<IUserRepository, UserRepository>();
            container.RegisterPerWebRequest<IRoleRepository, RoleRepository>();
            container.RegisterPerWebRequest<IUserRolesRepository, UserRolesRepository>();

            #endregion
        }
    }
}