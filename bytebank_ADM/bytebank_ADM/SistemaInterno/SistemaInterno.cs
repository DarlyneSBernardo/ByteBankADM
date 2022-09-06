using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public  class SistemaInterno
    {
        public bool Logar(Autenticavel autenticavel, string login, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(login,senha);

            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
