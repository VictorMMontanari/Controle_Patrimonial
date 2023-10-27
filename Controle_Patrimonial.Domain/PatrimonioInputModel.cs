using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Controle_Patrimonial.Domain
{
    public class PatrimonioInputModel
    {
        public string CodigoBarra { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string NotaFiscal { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataRegistro { get; set; }
        public int UsuarioId { get; set; }
        public int BlocoId { get; set; }
    }
}
