using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Patrimonial.Domain;

namespace Infra.SqlServer.Interfaces
{
    public interface ICheckInPatrimonioRepository
    {
        void AddCheckInPatrimonio(CheckInPatrimonio checkInPatrimonio);
        public List<CheckInPatrimonio> GetAllCheckInPatrimonio();
        public CheckInPatrimonio GetByIdCheckInPatrimonio(int id);
        public CheckInPatrimonio PostCheckInPatrimonio(int checkInId, int patrimonioId);
        CheckInPatrimonio PostCheckInPatrimonio(int checkInId, int patrimonioId, DateTime dataCheckIn);
        public void PutCheckInPatrimonio(CheckInPatrimonio checkInPatrimonio);
    }
}
