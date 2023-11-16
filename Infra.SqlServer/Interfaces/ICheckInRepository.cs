using Controle_Patrimonial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SqlServer.Interfaces
{
    public interface ICheckInRepository
    {
        public List<CheckIn> GetAllCheckIn();
        public CheckIn GetByIdCheckIn(int id);
        public List<Patrimonio> GetAllYearPatrimonio(int year);
        public void PostCheckIn(CheckIn checkIn);
        void PostCheckIn(Patrimonio checkin);
        public void PutCheckIn(CheckIn checkIn);
    }
}
