using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.SqlServer.Interfaces;

namespace Controle_Patrimonial.Domain.Service
{
    public class Login
    {
        readonly IUsuarioRepository _usuarioRepository;
        public Login(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Validacao (string email, string senha)
        {
            var useremil = _usuarioRepository.GetEmail(email);
            var usersenha = _usuarioRepository.GetSenha(senha);
            if (useremil == email && usersenha == senha)
            {
                return true;
            } 
            else
            {
                return false;
            }
        } 
    }
}
