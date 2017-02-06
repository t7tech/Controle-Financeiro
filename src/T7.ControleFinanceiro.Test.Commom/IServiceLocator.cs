namespace T7.ControleFinanceiro.Test.Commom
{
    // Common service locator interface
    public interface IServiceLocator
    {
        T Get<T>();
    }
}