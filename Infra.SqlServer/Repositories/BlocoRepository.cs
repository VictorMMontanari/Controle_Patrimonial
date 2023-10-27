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
    public class BlocoRepository : IBlocoRepository
    {
        private readonly SqlServerContex _context;

        public BlocoRepository(SqlServerContex context)
        {
            _context = context;
        }

        public List<Bloco> GetAllBloco()
        {
            return _context.Blocos.ToList();
        }

        public Bloco GetByIdBloco(int id)
        {
            return _context.Blocos.Find(id);
        }
        public void PostBloco(Bloco bloco)
        {
            _context.Blocos.Add(bloco);
            _context.SaveChanges();
        }
        public void PutBloco(Bloco bloco)
        {
            _context.Entry(bloco).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteBloco(int id)
        {
            var bloco = _context.Blocos.First(i => i.BlocoId == id);
            bloco.Ativo = false;
            _context.SaveChanges();
        }
    }
}
