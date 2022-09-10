using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }


        public static int totalFuncionarios { get; private set; }

        public Funcionario ( string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;  
            totalFuncionarios ++;
        }
        public abstract void AumentaSalario();

        public abstract double Bonificacao();
        
    }
}
