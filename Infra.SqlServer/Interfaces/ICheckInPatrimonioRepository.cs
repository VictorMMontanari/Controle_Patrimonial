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
        public List<CheckInPatrimonio> GetAllCheckInPatrimonio();
        public CheckInPatrimonio GetByIdCheckInPatrimonio(int id);
        public CheckInPatrimonio PostCheckInPatrimonio(int checkInId, int patrimonioId);
        public void PutCheckInPatrimonio(CheckInPatrimonio checkInPatrimonio);
    }
}
