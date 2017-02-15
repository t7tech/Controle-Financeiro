using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using System;
using System.Linq;
using System.Data.Entity;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Configuration;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Context;
using T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model;
using T7.ControleFinanceiro.Infra.Data.Repository.Account;
using T7.ControleFinanceiro.Service.Account;
using T7.ControleFinanceiro.Test.Commom;
using Microsoft.Owin.Security;
using System.Web;

namespace T7.ControleFinanceiro.Test.Dependency
{
    public class UnityRegistrationModule : IContainerRegistrationModule<IUnityContainer>
    {
        // Register dependencies in unity container
        public void Register(IUnityContainer container)
        {
            var userInjectorConstructor = new InjectionConstructor(new ApplicationDbContext());

            // register service locator
            container.RegisterType<IServiceLocator, CustomUnityServiceLocator>();

            container.RegisterType<ApplicationDbContext>();
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new InjectionConstructor(typeof(ApplicationDbContext)));
            container.RegisterType<IRoleStore<IdentityRole, string>, RoleStore<IdentityRole>>();
            container.RegisterType<ApplicationRoleManager>();
            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<ApplicationSignInManager>();
            container.RegisterType<IAuthenticationManager>(new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

            // register services
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRolesService, UserRolesService>();
            container.RegisterType<IClaimService, ClaimService>();
            container.RegisterType<IUserClaimsService, UserClaimsService>();
            container.RegisterType<IRegisterService, RegisterService>();

            // register repository
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserRolesRepository, UserRolesRepository>();
            container.RegisterType<IClaimRepository, ClaimRepository>();
            container.RegisterType<IUserClaimsRepository, UserClaimsRepository>();
        }
    }
}