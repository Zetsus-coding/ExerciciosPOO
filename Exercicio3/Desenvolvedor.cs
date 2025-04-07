using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Desenvolvedor : Funcionario
    {
        // Enums de especialidade e nível
        public enum EnumEspecialidade
        {
            FrontEnd,
            BackEnd,
            FullStack
        }

        public enum EnumNivel
        {
            Junior,
            Pleno,
            Senior
        }

        // Propriedade dos enums
        public EnumEspecialidade Especialidade { get; set; }
        public EnumNivel Nivel { get; set; }

        public Desenvolvedor(string nome, string cpf, DateTime data, double salario, EnumEspecialidade especialidade, EnumNivel nivel)
            : base(nome, cpf, data, salario)
        {
            this.Especialidade = especialidade;
            this.Nivel = nivel;
        }

        // Métodos
        public override void ExibirDados() // Usa o exibir dados da classe base e só adiciona as informações exclusivas de desenvolvedor
        {
            Console.WriteLine(" ----- Exibindo dados do Desenvolvedor -----" + "\n");

            base.ExibirDados();

            Console.WriteLine("Especialidade: " + Especialidade);
            Console.WriteLine("Nível: " + Nivel);
        }

        public override void CalcularSalario() // Multiplica o valor do salário base por 1.5
        {
            Console.WriteLine("Salário final do desenvolvedor (1.5x): " + SalarioBase * (1.5));
        }
    }
}
