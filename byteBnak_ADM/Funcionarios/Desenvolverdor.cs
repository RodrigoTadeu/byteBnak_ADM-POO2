using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.Funcionarios
{
    public class Desenvolverdor: Funcionario
    {
        public Desenvolverdor(string cpf) : base(cpf, 3000)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }

        public override double Bonificacao()
        {
            return Salario * 0.10;
        }
    }
}
