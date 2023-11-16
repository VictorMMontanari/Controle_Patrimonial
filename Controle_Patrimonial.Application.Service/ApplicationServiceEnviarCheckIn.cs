using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Patrimonial.Domain;
using Controle_Patrimonial.Domain.Service;

namespace Controle_Patrimonial.Application.Service
{
    public class ApplicationServiceEnviarCheckIn
    {
        readonly EnviarCheckInService _checkInService;
        public ApplicationServiceEnviarCheckIn(EnviarCheckInService checkInService)
        {
            _checkInService = checkInService;
        }

        public List<Patrimonio> SendCheckIn(int year)
        {
            var listPatrimonio = _checkInService.EnviarPatrimonios(year);
            if (listPatrimonio != null)
            {
                return listPatrimonio;
            }
            else
            {
                return null;
            }
        }
    }
}
