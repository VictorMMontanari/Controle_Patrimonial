﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Patrimonial.Domain;
using Infra.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.SqlServer.Repositories
{
    public class CheckInPatrimonioRepository : ICheckInPatrimonioRepository
    {
        private readonly SqlServerContex _context;
        
        public CheckInPatrimonioRepository(SqlServerContex contex)
        {
            _context = contex;
        }

        public List<CheckInPatrimonio> GetAllCheckInPatrimonio()
        {
            return _context.CheckInPatrimonios.ToList();
        }
        public CheckInPatrimonio GetByIdCheckInPatrimonio(int id)
        {
            return _context.CheckInPatrimonios.Find(id);
        }
        public CheckInPatrimonio PostCheckInPatrimonio(int checkInId, int patrimonioId)
        {
            var checkIn = _context.CheckIns.First(i => i.CheckInId == checkInId);
            var patrimonio = _context.Patrimonios.First(i => i.PatrimonioId == patrimonioId);
            var checkInPatrimonio = new CheckInPatrimonio
            {
                CheckIn = checkIn,
                Patrimonio = patrimonio
            };

            _context.Add(checkInPatrimonio);
            _context.SaveChanges();
            return checkInPatrimonio;
        }
        public void PutCheckInPatrimonio(CheckInPatrimonio checkInPatrimonio)
        {
            _context.CheckInPatrimonios.Entry(checkInPatrimonio).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
