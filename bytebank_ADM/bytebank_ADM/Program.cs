using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração!");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "João";
pedro.CPF = "123545698";
pedro.Salario = 2000;

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("CPF: " + pedro.CPF);
//Console.WriteLine("Salário: " + pedro.Salario);

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.CPF = "12568745623";
paula.Salario = 5000;

Console.WriteLine("Bonificação: " + pedro.GetBonificacao());
Console.WriteLine("Bonificação: " + paula.GetBonificacao());

gerenciador.Registrar(pedro);
Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao());
gerenciador.Registrar(paula);
Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao());

Console.ReadKey();