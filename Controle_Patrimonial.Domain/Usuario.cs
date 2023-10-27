using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Patrimonial.Domain
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string CPF {  get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }

        // Ligaçoes
        public IList<Patrimonio>? Patrimonios { get; set;}
        public IList<CheckIn>? CheckIns { get; set; }
    }
}
