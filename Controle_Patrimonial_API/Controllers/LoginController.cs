using Controle_Patrimonial.Application.Service;
using Controle_Patrimonial.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public ActionResult<LoginService> validarLogin(string email, string senha)
        {
            return Ok(_loginService.ValidarLogin(email, senha));
        }
    }
}
