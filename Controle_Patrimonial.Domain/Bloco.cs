using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Patrimonial.Domain
{
    public class Bloco
    {
        [Key]
        public int BlocoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        // Ligaçoes
        public IList<Patrimonio>? Patrimonios { get; set;}
    }
}
