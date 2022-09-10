using byteBnak_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base( cpf, 5000)
        {

        }
        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }


        public override double Bonificacao()
        {
            return Salario * 0.5;


        }


    }
}
