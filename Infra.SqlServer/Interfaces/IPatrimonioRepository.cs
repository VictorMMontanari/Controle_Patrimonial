using Controle_Patrimonial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SqlServer.Interfaces
{
    public interface IPatrimonioRepository
    {
        public List<Patrimonio> GetAllPatrimonio();
        public Patrimonio GetByIdPatrimonio(int id);
        public void PostPatrimonio(Patrimonio patrimonio);
        public void PutPatrimonio(Patrimonio patrimonio);
        public void DeletePatrimonio(int patrimonioId);
    }
}
