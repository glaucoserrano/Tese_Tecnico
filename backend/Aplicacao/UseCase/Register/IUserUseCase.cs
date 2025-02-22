using Comunicacao.Response;

namespace Aplicacao.UseCase.Register
{
    public interface IUserUseCase
    {
        Task<ResponseUserJson> Execute();
    }
}
