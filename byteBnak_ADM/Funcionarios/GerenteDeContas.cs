using byteBnak_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }

        public override double Bonificacao()
        {
            return Salario * 0.25;
        }

      
    }
}
