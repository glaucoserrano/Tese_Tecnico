using Comunicacao.Response;
using Comunicacao.Services;

namespace Aplicacao.UseCase
{
    public class UserUseCase : IUserUseCase
    {
        private readonly RandomUserServices _randomUserServices;

        public UserUseCase(RandomUserServices randomUserServices)
        {
            _randomUserServices = randomUserServices;
        }

        public async Task<ResponseUserJson> Execute()
        {
            var user = await _randomUserServices.GetRandomUser();
            string name = $"{user?.name?.first} {user?.name?.last}";
            string? email = user?.email;
            


            return new ResponseUserJson{
                Name = name,
                Email = email!
            };
        }
    }
}
