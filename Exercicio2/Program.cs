using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Usando o construtor completo
            Produto produto1 = new Produto( "001", "Notebook",2500.00, 10, DateTime.Now);
            ExibirInformacoes(produto1);

            Console.WriteLine(); // pula linha

            // Usando o construtor essencial
            Produto produto2 = new Produto("002", "Mouse", 50.00);
            produto2.Estoque = 100;
            ExibirInformacoes(produto2);

            Console.WriteLine(); // pula linha

            // Tentativa de nome vazio
            Produto produto3 = new Produto();
            produto3.Nome = "";

            // Tentativa de preço negativo
            Produto produto4 = new Produto();
            produto4.Preco = -100;

            // Tentativa de estoque negativo
            Produto produto5 = new Produto();
            produto5.Estoque = -10;
        }

        static void ExibirInformacoes(Produto produto)
        {
            Console.WriteLine($"Código: {produto.Codigo}");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco:C}");
            Console.WriteLine($"Estoque: {produto.Estoque}");
            Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
            Console.WriteLine($"Valor em Estoque: {produto.ValorEmEstoque:C}");
            Console.WriteLine($"Status: {produto.Status}");
        }
    }
}