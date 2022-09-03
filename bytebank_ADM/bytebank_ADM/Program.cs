using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;



Console.WriteLine("Boas Vindas, ao ByteBank Administração!");

CalcularBonificacao();
#region Codigo antigo
//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//Funcionario objFuncionario = new Funcionario("123545698", 2000);
//objFuncionario.Nome = "Pedro";
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalFuncionarios);

//Diretor objDiretor = new Diretor("12568745623", 5000);
//objDiretor.Nome = "Paula";
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalFuncionarios);

//Funcionario objFuncDiretor = new Diretor("89874756321", 3000);
//objFuncDiretor.Nome = "André";
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalFuncionarios);

//Console.WriteLine("Bonificação: " + objFuncionario.GetBonificacao());
//Console.WriteLine("Bonificação: " + objDiretor.GetBonificacao());
//Console.WriteLine("Bonificação: " + objFuncDiretor.GetBonificacao());

//gerenciador.Registrar(objFuncionario);
//gerenciador.Registrar(objDiretor);
//gerenciador.Registrar(objFuncDiretor);

//Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao());
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

//objFuncDiretor.AumentarSalario();
//Console.WriteLine("Novo salário do André: " + objFuncDiretor.Salario);

//objFuncDiretor.AumentarSalario();
//Console.WriteLine("Novo salário do Pedro: " + objFuncionario.Salario);
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer designer = new Designer("833.222.048-39");
    designer.Nome = "Pedro";

    Diretor diretor = new Diretor("159.753.398-04");
    diretor.Nome = "Paula";

    Auxiliar auxiliar = new Auxiliar("981.198.778-53");
    auxiliar.Nome = "Igor";

    GerenteDeContas gerente = new GerenteDeContas("326.985.628-89");
    gerente.Nome = "Camila";

    gerenciador.Registrar(designer);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(gerente);

    Console.WriteLine("Total de Bonificação: " + gerenciador.GetBonificacao());
}

Console.ReadKey();