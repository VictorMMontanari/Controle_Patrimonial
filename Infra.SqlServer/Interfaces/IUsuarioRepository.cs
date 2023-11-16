using Controle_Patrimonial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SqlServer.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetAllUsuario();
        public Usuario GetByIdUsuario(int id);
        public void PostUsuario(Usuario usuario);
        public void PutUsuario(Usuario usuario);
        public void DeleteUsuario(int usuarioId);
        public string GetEmail(string email);
        public string GetSenha(string senha);
    }
}
