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
        
        public virtual double GetBonificacao()
        {
            return Salario * 0.1;                     
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }    
    }
}
