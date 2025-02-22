using Dominio.Entities;

namespace Dominio.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<List<User>> GetAll();
        Task<User?> GetById(int id);
        Task Update(User user);
    }
}
