using byteBnak_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.SistemaInterno
{
    public interface IAutenticavel
    {

        public bool Autenticar(string senha);
       

    }
}
