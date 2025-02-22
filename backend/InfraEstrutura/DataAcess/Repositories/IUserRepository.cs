using Dominio.Entities;

namespace InfraEstrutura.DataAcess.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
    }
}
