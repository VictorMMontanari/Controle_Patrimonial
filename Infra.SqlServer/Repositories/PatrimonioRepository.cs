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
    public class PatrimonioRepository : IPatrimonioRepository
    {
        private readonly SqlServerContex _context;

        public PatrimonioRepository(SqlServerContex contex)
        {
            _context = contex;
        }

        public List<Patrimonio> GetAllPatrimonio()
        {
            return _context.Patrimonios.ToList();
        }

        public Patrimonio GetByIdPatrimonio(int id)
        {
            return _context.Patrimonios.Find(id);
        }
        public void PostPatrimonio(Patrimonio patrimonio)
        {
            _context.Patrimonios.Add(patrimonio);
            _context.SaveChanges();
        }
        public void PutPatrimonio(Patrimonio patrimonio)
        {
            _context.Entry(patrimonio).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeletePatrimonio(int patrimonioId)
        {
            var patrimonio = _context.Patrimonios.First(i => i.PatrimonioId == patrimonioId);
            patrimonio.Ativo = false;
            _context.SaveChanges();
        }
    }
}
