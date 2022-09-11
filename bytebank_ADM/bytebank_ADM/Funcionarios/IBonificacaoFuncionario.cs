using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    //Desafio
    public interface IBonificacaoFuncionario
    {
        public void AumentarSalario();
        public double GetBonificacao();
    }
}
