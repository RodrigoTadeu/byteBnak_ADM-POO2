using byteBnak_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificaçao;

        public void Registrar (Funcionario funcionario)
        {
            this.totalBonificaçao += funcionario.Bonificacao();
        }

        public double Bonificacao()
        {
            return this.totalBonificaçao;
        }
    }
}
