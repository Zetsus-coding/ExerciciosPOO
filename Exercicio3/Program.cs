using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program()
    {
        static void Main(string[] args)
        {
            // Desenvolvedor
            Desenvolvedor dev = new Desenvolvedor(
                "João",
                "123.456.789-10",
                DateTime.Now,
                6653.25,
                Desenvolvedor.EnumEspecialidade.BackEnd,
                Desenvolvedor.EnumNivel.Pleno
            );

            dev.ExibirDados();
            dev.CalcularSalario();

            // Atendente
            Atendente atende = new Atendente(
                "Raphael",
                "000.111.222-33",
                DateTime.Now,
                5900,
                "1000 vendas",
                13
            );

            atende.ExibirDados();
            atende.CalcularSalario();

            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }
}