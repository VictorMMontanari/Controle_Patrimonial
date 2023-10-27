using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Patrimonial.Domain
{
    public class CheckinInputModel
    {
        public int CheckInId { get; set; }
        public DateTime DataEnvio { get; set; }
        public string EmailEnviado { get; set; }
        public int UsuarioId { get; set; }
    }
}
