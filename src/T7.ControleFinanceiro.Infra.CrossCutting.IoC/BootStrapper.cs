using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Repository.OAuth;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account.Settings;
using T7.ControleFinanceiro.Domain.Interface.Service.OAuth;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Context;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;
using T7.ControleFinanceiro.Infra.Data.Repository.Account;
using T7.ControleFinanceiro.Infra.Data.Repository.Account.Settings;
using T7.ControleFinanceiro.Service.Account;
using T7.ControleFinanceiro.Service.Account.Settings;
using T7.ControleFinanceiro.Service.OAuth;

namespace T7.ControleFinanceiro.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            #region Identity

            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();

            #endregion

            #region Service

            container.RegisterPerWebRequest<IUserService, UserService>();
            container.RegisterPerWebRequest<IRoleService, RoleService>();
            container.RegisterPerWebRequest<IUserRolesService, UserRolesService>();
            container.RegisterPerWebRequest<IRegisterService, RegisterService>();
            container.RegisterPerWebRequest<ILoginService, LoginService>();
            container.RegisterPerWebRequest<IProfileService, ProfileService>();

            #endregion

            #region Repository

            container.RegisterPerWebRequest<IUserRepository, UserRepository>();
            container.RegisterPerWebRequest<IRoleRepository, RoleRepository>();
            container.RegisterPerWebRequest<IUserRolesRepository, UserRolesRepository>();
            container.RegisterPerWebRequest<IProfileRepository, ProfileRepository>();

            #endregion
        }
    }
}