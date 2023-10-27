using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Patrimonial_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInController : ControllerBase
    {
        readonly ICheckInRepository _checkInRepository;

        public CheckInController(ICheckInRepository checkInRepository)
        {
            _checkInRepository = checkInRepository;
        }

        [HttpGet]
        public ActionResult<List<CheckIn>> Get()
        {
            return Ok(_checkInRepository.GetAllCheckIn());
        }
        [HttpGet("{id}")]
        public ActionResult<CheckIn> GetById(int id)
        {
            return Ok(_checkInRepository.GetByIdCheckIn(id));
        }
        [HttpPost]
        public ActionResult<CheckIn> PostCheckIn([FromBody] CheckinInputModel model)
        {
            var checkin = new CheckIn
            {
                DataEnvio = model.DataEnvio,
                EmailEnviado = model.EmailEnviado,
                UsuarioId = model.UsuarioId
            };
            _checkInRepository.PostCheckIn(checkin);
            return CreatedAtAction(nameof(GetById), new { id = checkin.CheckInId }, checkin);
        }
        [HttpPut]
        public ActionResult<CheckIn> PutCheckIn(CheckIn checkIn)
        {
            _checkInRepository.PutCheckIn(checkIn);
            return Ok("CheckIn Atualizado com sucesso!");
        }
    }
}
