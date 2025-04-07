using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Atendente : Funcionario
    {
        // Propriedades
        public string MetaAtendimento { get; set; }
        public double Comissao { get; set; }

        // Construtor
        public Atendente(string nome, string cpf, DateTime data, double salario, string meta, double comissao)
            : base(nome, cpf, data, salario)
        {
            MetaAtendimento = meta;
            Comissao = comissao;
        }

        // Métodos
        public override void ExibirDados() // Usa o exibir dados da classe base e só adiciona as informações exclusivas do atendente
        {
            Console.WriteLine(" ----- Exibindo dados do Atendente -----" + "\n");

            base.ExibirDados();

            Console.WriteLine("Meta de atendimentos: " + MetaAtendimento);
            Console.WriteLine("Comissão (caso atinja a meta): " + Comissao);
        }

        public override void CalcularSalario() // Multiplica o valor do salário base por (1 + (comissao/100))
        {
            Console.WriteLine("Salário final do atendente (1 + (comissao/100)): " + Math.Round(SalarioBase * (1 + (Comissao / 100))));
        }
    }
}
