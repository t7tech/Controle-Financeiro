namespace T7.ControleFinanceiro.Test.Commom
{
    // Common DI container registration module interface
    public interface IContainerRegistrationModule<T>
    {
        void Register(T container);
    }
}