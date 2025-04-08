using System;

namespace Exercicio1
{
    public class Program()
    {
        static void Main()
        {
            // Instâncias/Objetos
            ContaBancaria conta1 = new ContaBancaria("12345-6", "Guilherme");
            ContaBancaria conta2 = new ContaBancaria("78901-2", "Bob");
            ContaBancaria conta3 = new ContaBancaria("32911-5", "Teresa");

            // Operações
            conta1.Depositar(500);
            conta1.Sacar(200);
            
            conta2.Depositar(1000);
            conta2.Sacar(1500); // Saldo insuficiente

            conta3.Depositar(-100); // Negativo
            conta3.Sacar(-200); // Negativo

            // Exibição do extrato
            Console.WriteLine("\nExtrato da conta de Guilherme:");
            foreach (var transacao in conta1.VerExtrato())
            {
                Console.WriteLine($"{transacao.Data} - {transacao.Tipo} - {transacao.Valor} - {transacao.Descricao}");
            }

            Console.WriteLine("\nExtrato da conta de Bob:");
            foreach (var transacao in conta2.VerExtrato())
            {
                Console.WriteLine($"{transacao.Data} - {transacao.Tipo} - {transacao.Valor} - {transacao.Descricao}");
            }
            
            Console.WriteLine("\nExtrato da conta de Teresa:");
            foreach (var transacao in conta3.VerExtrato())
            {
                Console.WriteLine($"{transacao.Data} - {transacao.Tipo} - {transacao.Valor} - {transacao.Descricao}");
            }
        }
    }
}