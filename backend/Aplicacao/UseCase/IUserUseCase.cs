using Comunicacao.Response;

namespace Aplicacao.UseCase
{
    public interface IUserUseCase
    {
        Task<ResponseUserJson> Execute();
    }
}
