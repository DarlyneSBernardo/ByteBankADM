using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        //0 - Funcionário
        //1 - diretor
        //2 - designer
        //N - ...
        //private int _tipo;
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("Criando funcionário.");
            TotalFuncionarios++;
        }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Toda classe que herdar Funcionário precisará implementar esses métodos obrigatoriamente por serem abstratos.
        //Métodos abstratos só podem existir dentro de classes abstratas, classes completas não podem ter métodos abstratos.
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();        
    }
}
