using Comunicacao.Request;

namespace Aplicacao.UseCase.Update
{
    public interface IUserUpdateUseCase
    {
        Task Execute(RequestUserJson request);
    }
}
