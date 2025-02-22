using Comunicacao.DTO;
using Comunicacao.Response;
using Comunicacao.Services;
using Dominio.Entities;
using Dominio.Repositories;

namespace Aplicacao.UseCase.Register
{
    public class UserUseCase : IUserUseCase
    {
        private readonly RandomUserServices _randomUserServices;
        private readonly IUserRepository _userRepostory;
        public UserUseCase(RandomUserServices randomUserServices, IUserRepository userRepository)
        {
            _randomUserServices = randomUserServices;
            _userRepostory = userRepository;
        }

        public async Task<ResponseUserJson> Execute()
        {
            UserDTO? user = await _randomUserServices.GetRandomUser();
            string name = $"{user?.name?.first} {user?.name?.last}";
            string? email = user?.email;
            string? gender = user?.gender;
            string? cell = user?.cell;

            User userEntitie = new User();
            
            userEntitie.name = name;
            userEntitie.email = email!;
            userEntitie.gender = gender!;
            userEntitie.cell = cell!;

            await _userRepostory.AddUser(userEntitie);

            return new ResponseUserJson{
                Name = name,
                Email = email!
            };
        }
    }
}
