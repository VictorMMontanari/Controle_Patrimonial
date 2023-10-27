using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Controle_Patrimonial.Domain
{
    public class CheckInPatrimonio
    {
        [Key]
        public int CheckInPatrimonioId { get; set; }

        public int CheckInId { get; set; }
        public CheckIn CheckIn { get; set; }

        public int PatrimonioId { get; set; }
        public Patrimonio Patrimonio { get; set; }
    }
}
