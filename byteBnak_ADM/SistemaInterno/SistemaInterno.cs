using byteBnak_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBnak_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public bool Logar (IAutenticavel funcionario, string senha )
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado==true )
            {
                Console.WriteLine("Seja bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha errada!");
                return false;
            }
        }

     
        
    }
}
