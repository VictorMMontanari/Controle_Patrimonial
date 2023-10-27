using Controle_Patrimonial.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SqlServer.Interfaces
{
    public interface IBlocoRepository
    {
        public List<Bloco> GetAllBloco();
        public Bloco GetByIdBloco(int id);
        public void PostBloco(Bloco bloco);
        public void PutBloco(Bloco bloco);
        public void DeleteBloco(int id);
    }
}
