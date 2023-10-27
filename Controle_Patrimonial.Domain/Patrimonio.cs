using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Patrimonial.Domain
{
    public class Patrimonio
    {
        [Key]
        public int PatrimonioId { get; set; }
        public string CodigoBarra { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string NotaFiscal { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataRegistro { get; set; }

        // Ligaçoes
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int BlocoId { get; set; }
        public Bloco Bloco { get; set; } = null!;
        public IList<CheckIn>? CheckIns { get; set; }
    }
}
