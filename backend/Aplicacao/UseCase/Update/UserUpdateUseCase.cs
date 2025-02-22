using Comunicacao.Request;
using Dominio.Entities;
using Dominio.Repositories;

namespace Aplicacao.UseCase.Update
{
    public class UserUpdateUseCase :IUserUpdateUseCase
    {
        private readonly IUserRepository _repository;

        public UserUpdateUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(RequestUserJson request)
        {
            User? user = await _repository.GetById(request.Id);
            if (user == null)
                throw new Exception("Usuário não Encontrado");

            user.name = request.name;
            user.email = request.email;
            user.gender = request.gender;
            user.cell = request.cell;

            await _repository.Update(user);
        }
    }
}
