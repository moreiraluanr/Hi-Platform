namespace Mercado.Aplicattion.UseCase.Interface
{
    public interface IUseCase<TRequest>
    {
        void Execute(TRequest request);
    }

    public interface IUseCase<TRequest, TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
