using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SqlServer.Repositories
{
    public class CheckInRepository : ICheckInRepository
    {
        private readonly SqlServerContex _context;

        public CheckInRepository(SqlServerContex context)
        {
            _context = context;
        }

        public List<CheckIn> GetAllCheckIn()
        {
            return _context.CheckIns.ToList();
        }

        public CheckIn GetByIdCheckIn(int id)
        {
            return _context.CheckIns.Find(id);
        }
        public void PostCheckIn(CheckIn checkIn)
        {
            _context.CheckIns.Add(checkIn);
            _context.SaveChanges();
        }

        public List<Patrimonio> GetAllYearPatrimonio(int year)
        {
            return _context.Patrimonios.Where(i => i.DataRegistro.Year == year).ToList();
        }

        public void PostCheckIn(Patrimonio checkin)
        {
            throw new NotImplementedException();
        }

        public void PutCheckIn(CheckIn checkIn)
        {
            _context.Entry(checkIn).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
