using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatrimonioController : ControllerBase
    {
        readonly IPatrimonioRepository _patrimonioRepository;

        public PatrimonioController(IPatrimonioRepository patrimonioRepository)
        {
            _patrimonioRepository = patrimonioRepository;
        }

        [HttpGet]
        public ActionResult<List<Patrimonio>> Get()
        {
            return Ok(_patrimonioRepository.GetAllPatrimonio());
        }
        [HttpGet("{id}")]
        public ActionResult<Patrimonio> GetById(int id)
        {
            return Ok(_patrimonioRepository.GetByIdPatrimonio(id));
        }
        [HttpPost]
        public ActionResult<Patrimonio> PostPatrimonio([FromBody] PatrimonioInputModel model)
        {
            // Crie uma instância de Patrimonio com os IDs do Bloco e do Usuario
            var patrimonio = new Patrimonio
            {
                CodigoBarra = model.CodigoBarra,
                Tipo = model.Tipo,
                Nome = model.Nome,
                Valor = model.Valor,
                NotaFiscal = model.NotaFiscal,
                Ativo = model.Ativo,
                DataRegistro = model.DataRegistro,
                UsuarioId = model.UsuarioId,
                BlocoId = model.BlocoId
            };

            _patrimonioRepository.PostPatrimonio(patrimonio);
            return CreatedAtAction(nameof(GetById), new { id = patrimonio.PatrimonioId }, patrimonio);
        }

        [HttpPut]
        public ActionResult<Patrimonio> PutPatrimonio(Patrimonio patrimonio)
        {
            _patrimonioRepository.PutPatrimonio(patrimonio);
            return Ok("Patrimonio Atualizado com sucesso!");
        }
        [HttpPut("{id}")]
        public ActionResult<Patrimonio> DeletePatrimonio(int id)
        {
            _patrimonioRepository.DeletePatrimonio(id);
            return Ok("Patrimonio Deletedo");
        }

    }
}
