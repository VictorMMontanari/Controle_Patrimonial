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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlServerContex _context;

        public UsuarioRepository(SqlServerContex contex)
        {
            _context = contex;

        }

        public List<Usuario> GetAllUsuario()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetByIdUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }
        public void PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
        public void PutUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteUsuario(int usuarioId)
        {
            var usuario = _context.Usuarios.First(i => i.UsuarioId == usuarioId);
            usuario.Ativo = false;
            _context.SaveChanges();
        }
    }
}
