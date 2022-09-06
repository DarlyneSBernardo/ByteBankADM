using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;



Console.WriteLine("Boas Vindas, ao ByteBank Administração!");

//CalcularBonificacao();
UsarSistema();

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

    Desenvolvedor desenvolvedor = new Desenvolvedor("536.579.458-25");
    desenvolvedor.Nome = "Samya";

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
    gerenciador.Registrar(desenvolvedor);

    Console.WriteLine("Total de Bonificação: " + gerenciador.GetBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor diretora = new Diretor("145.146.789-56");
    diretora.Nome = "Roberta";
    diretora.Login = "roberta.diretora";
    diretora.Senha = "123";

    GerenteDeContas gerente = new GerenteDeContas("145.146.789-56");
    gerente.Nome = "Ursula";
    gerente.Login = "ursula.gerente";
    gerente.Senha = "321";

    //Funcionario func = new Designer("326.985.628-89");
    //func.Nome = "Pedro";
    //func.Senha = "123";

    //sistemaInterno.Logar(func, "123");
    sistemaInterno.Logar(diretora, "ursula", "123");
    sistemaInterno.Logar(gerente, gerente.Login, "123");
}


Console.ReadKey();