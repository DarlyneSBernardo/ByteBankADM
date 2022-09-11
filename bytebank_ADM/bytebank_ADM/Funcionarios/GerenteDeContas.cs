using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public  class GerenteDeContas:FuncionarioAutenticavel, IBonificacaoFuncionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um Gerente de Contas.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }
    }
}
