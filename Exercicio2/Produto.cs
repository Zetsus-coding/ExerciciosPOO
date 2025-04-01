using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Produto
    {
        // ----- Propriedades autoimplementadas -----
        public string? Codigo { get; set; }

        // ----- Propriedades com validação -----
        // *Quando se aplica "lógica" personalizada, tanto o get quanto o set devem utilizar do atributo privado

        private string _nome; // Atributo privado 1
        public string Nome // Propriedade com validação 1
        { 
            get => _nome; //* 
            set
            {
                if(String.IsNullOrWhiteSpace(value)) // Validação se nome é vazio (TRUE = VAZIO)
                {
                    Console.WriteLine("O nome informado não pode ser vazio");
                }
                else
                {
                    _nome = value; //*
                }
            }
        }

        private double _preco;// Atributo privado 2
        public double Preco // Propriedade com validação 2
        {
            get => _preco;

            set
            {
                if (value < 0) // Valida se preço é negativo (pode ser 0)
                {
                    Console.WriteLine("O preço informado não pode ser negativo");
                }
                else 
                {
                    _preco = value;
                }
            }
        }

        private int _estoque; // Atributo privado 3
        public int Estoque // Propriedade com validação 3
        {
            get => _estoque;
            set
            {
                if (value < 0) // Valida se estoque é negativo (pode ser 0)
                {
                    Console.WriteLine("O estoque informado não pode ser negativo");
                }
                else 
                { 
                    _estoque = value;
                }
            }
        }

        // ----- Propriedade somente leitura -----

        private DateTime _dataCadastro; // Atributo privado

        public DateTime DataCadastro // Propriedade somente leitura
        {
            get => _dataCadastro;
        }

        // ----- Propriedades calculadas -----

        public double ValorEmEstoque // Propriedade calculada 1
        {
            get => _preco * _estoque;
        }
        public string Status //Propriedade calculada 2
        {
            get
            {
                if (Estoque > 0)
                {
                    return "Em estoque";
                }
                else
                {
                    return "Sem estoque";
                }
            }
        }

        // Construtor "Completo" (já que ValorEmEstoque e Status são adquiridos como resultado do preenchimento de outras propriedades)
        public Produto(string codigo, string nome, double preco, int estoque, DateTime data)
        {
            Nome = nome;
            Codigo = codigo;
            Preco = preco;
            Estoque = estoque;
            _dataCadastro = data;
        }

        // Construtor essencial
        public Produto(string codigo, string nome, double preco)
        {
            Nome = nome;
            Codigo = codigo;
            Preco = preco;
        }

        // Construtor padrão
        public Produto()
        {
           _dataCadastro = DateTime.Now;
        }
    }
}
