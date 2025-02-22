using Aplicacao.UseCase;
using Comunicacao.Response;
using Microsoft.AspNetCore.Mvc;

namespace Teste_Tecnico_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ResponseUserJson),StatusCodes.Status201Created)]
        public async Task<IActionResult> RegisterUser([FromServices] IUserUseCase useCase)
        {
            var response = await useCase.Execute();
            return Created(string.Empty,response);
        }
    }
}
