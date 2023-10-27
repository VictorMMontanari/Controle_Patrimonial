using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return Ok(_usuarioRepository.GetAllUsuario());
        }
        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            return Ok(_usuarioRepository.GetByIdUsuario(id));
        }
        [HttpPost]
        public ActionResult<Usuario> PostUsuario(Usuario usuario)
        {
            _usuarioRepository.PostUsuario(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.UsuarioId }, usuario);
        }
        [HttpPut]
        public ActionResult<Usuario> PutUsuario(Usuario usuario)
        {
            _usuarioRepository.PutUsuario(usuario);
            return Ok("Usuario Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Usuario> DeleteUsuario(int id)
        {
            _usuarioRepository.DeleteUsuario(id);
            return Ok("Usuario Deletado");
        }
    }
}
