﻿namespace AluraHeranca.Funcionarios
{
    internal class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
