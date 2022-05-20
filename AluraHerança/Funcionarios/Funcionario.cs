namespace AluraHeranca.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get;  set; }
        public string CPF { get;  private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario ,string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            Console.WriteLine("construtor FUNCIONARIO");
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
