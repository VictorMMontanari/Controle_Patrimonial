using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocoController : ControllerBase
    {
        readonly IBlocoRepository _blocoRepository;

        public BlocoController(IBlocoRepository blocoRepository)
        {
            _blocoRepository = blocoRepository;
        }

        [HttpGet]
        public ActionResult<List<Bloco>> Get()
        {
            return Ok(_blocoRepository.GetAllBloco());
        }
        [HttpGet("{id}")]
        public ActionResult<Bloco> GetById(int id)
        {
            return Ok(_blocoRepository.GetByIdBloco(id));
        }
        [HttpPost]
        public ActionResult<Bloco> PostBloco(Bloco bloco)
        {
            _blocoRepository.PostBloco(bloco);
            return CreatedAtAction(nameof(GetById), new { id = bloco.BlocoId }, bloco);
        }
        [HttpPut]
        public ActionResult<Bloco> PutBloco(Bloco bloco)
        {
            _blocoRepository.PutBloco(bloco);
            return Ok("Bloco Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Bloco> DeleteBloco(int id)
        {
            _blocoRepository.DeleteBloco(id);
            return Ok("Bloco Deleteda com sucesso");
        }

    }
}
