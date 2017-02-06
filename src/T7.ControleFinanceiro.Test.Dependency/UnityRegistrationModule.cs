using Microsoft.Practices.Unity;
using T7.ControleFinanceiro.Domain.Interface.Repository;
using T7.ControleFinanceiro.Domain.Interface.Service;
using T7.ControleFinanceiro.Infra.Data.Repository;
using T7.ControleFinanceiro.Service;
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
            container.RegisterType<IRoleRepository, RoleRepository>();
        }
    }
}