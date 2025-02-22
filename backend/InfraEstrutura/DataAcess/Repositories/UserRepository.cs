using Dominio.Entities;
using Dominio.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InfraEstrutura.DataAcess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task<List<User>> GetAll()
        {
            return await _context.users.AsNoTracking().ToListAsync();
        }
        public async Task<User?> GetById(int id)
        {
            return await _context.users.FirstOrDefaultAsync(user => user.id == id);
        }
        public async Task Update(User user)
        {
            _context.users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
