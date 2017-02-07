using Microsoft.Practices.Unity;
using T7.ControleFinanceiro.Domain.Interface.Repository.Account;
using T7.ControleFinanceiro.Domain.Interface.Service.Account;
using T7.ControleFinanceiro.Infra.Data.Repository.Account;
using T7.ControleFinanceiro.Service.Account;
using T7.ControleFinanceiro.Test.Commom;

namespace T7.ControleFinanceiro.Test.Dependency
{
    public class UnityRegistrationModule : IContainerRegistrationModule<IUnityContainer>
    {
        // Register dependencies in unity container
        public void Register(IUnityContainer container)
        {
            // register service locator
            container.RegisterType<IServiceLocator, CustomUnityServiceLocator>();

            // register services
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRolesService, UserRolesService>();
            container.RegisterType<IClaimService, ClaimService>();
            container.RegisterType<IUserClaimsService, UserClaimsService>();

            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserRolesRepository, UserRolesRepository>();
            container.RegisterType<IClaimRepository, ClaimRepository>();
            container.RegisterType<IUserClaimsRepository, UserClaimsRepository>();
        }
    }
}