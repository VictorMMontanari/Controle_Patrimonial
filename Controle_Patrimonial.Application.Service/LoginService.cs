using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Patrimonial.Domain.Service;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Controle_Patrimonial.Application.Service
{
    public class LoginService
    {
        readonly Login _login;
        public LoginService(Login login)
        {
            _login = login;
        }
        public bool ValidarLogin(string email, string senha)
        {
            return _login.Validacao(email, senha); 
        }
    }
}
