using Dominio.Entities;

namespace Aplicacao.UseCase.Report
{
    public interface IUserReportsUseCase
    {
        Task<List<User>> Execute();
    }
}
