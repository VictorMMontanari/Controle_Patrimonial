using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.SqlServer.Interfaces;

namespace Controle_Patrimonial.Domain.Service
{
    public class EnviarCheckInService
    {
        readonly ICheckInRepository _checkInRepository;
        public EnviarCheckInService(ICheckInRepository checkInRepository)
        {
            _checkInRepository = checkInRepository;
        }

        public List<Patrimonio> EnviarPatrimonios(int year)
        {
            return _checkInRepository.GetAllYearPatrimonio(year);
        }
    }
}
