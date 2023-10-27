using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInPatrimonioController : ControllerBase
    {
        readonly ICheckInPatrimonioRepository _checkInPatrimonioRepository;
        public CheckInPatrimonioController(ICheckInPatrimonioRepository checkInPatrimonio)
        {
            _checkInPatrimonioRepository = checkInPatrimonio;
        }

        [HttpGet]
        public ActionResult<List<CheckInPatrimonio>> Get()
        {
            return Ok(_checkInPatrimonioRepository.GetAllCheckInPatrimonio());
        }
        [HttpGet("{id}")]
        public ActionResult<CheckInPatrimonio> GetById(int id)
        {
            return Ok(_checkInPatrimonioRepository.GetByIdCheckInPatrimonio(id));
        }
        [HttpPost]
        public ActionResult<CheckInPatrimonio> PostCheckInPatrimonio(int checkInId, int patrimonioId)
        {
            CheckInPatrimonio checkInPatrimonio = _checkInPatrimonioRepository.PostCheckInPatrimonio(checkInId, patrimonioId);
            return CreatedAtAction(nameof(GetById), new { id = checkInPatrimonio.CheckInPatrimonioId }, checkInPatrimonio);
        }
        [HttpPut]
        public ActionResult<CheckInPatrimonio> PutCheckInPatrimonio(CheckInPatrimonio checkInPatrimonio)
        {
            _checkInPatrimonioRepository.PutCheckInPatrimonio(checkInPatrimonio);
            return Ok("Atualizado");
        }
    }
}
