using AluraHeranca;
using AluraHeranca.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario();
carlos.Nome = "Carlos";
carlos.CPF = "546.879.157-20";
carlos.Salario = 2000;

Diretor roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.CPF = "454.658.148-3";
roberta.Salario = 5000;

gerenciador.Registrar(carlos);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
Console.ReadLine();