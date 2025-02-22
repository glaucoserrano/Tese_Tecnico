using System.Net.Mime;
using Aplicacao.UseCase.Register;
using Aplicacao.UseCase.Report;
using Aplicacao.UseCase.Update;
using Comunicacao.Request;
using Comunicacao.Response;
using Dominio.Entities;
using Dominio.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Teste_Tecnico_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseUserJson),StatusCodes.Status201Created)]
        public async Task<IActionResult> RegisterUser([FromServices] IUserUseCase useCase)
        {
            var response = await useCase.Execute();
            return Created(string.Empty,response);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<User>),StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllUsers([FromServices] IUserReportsUseCase useCase)
        {
            List<User> users = await useCase.Execute();
            return Ok(users);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateUser([FromServices] IUserUpdateUseCase useCase, [FromBody] RequestUserJson request)
        {
            await useCase.Execute(request);

            return NoContent();
        }
    }
}
