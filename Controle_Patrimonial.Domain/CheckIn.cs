using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Patrimonial.Domain
{
    public class CheckIn
    {
        [Key]
        public int CheckInId { get; set; }
        public DateTime DataEnvio { get; set; }
        public string EmailEnviado { get; set; }

        // Ligaçoes
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public IList<Patrimonio>? Patrimonios { get; set; }
    }
}
