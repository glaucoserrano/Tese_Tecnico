using Dominio.Entities;
using Dominio.Repositories;


namespace Aplicacao.UseCase.Report
{
    public class UserReportsUseCase : IUserReportsUseCase
    {
        private readonly IUserRepository _userRepository;

        public UserReportsUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Execute()
        {
            List<User> users = await _userRepository.GetAll();

            return users;
        }
    }
}
