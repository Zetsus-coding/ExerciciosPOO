using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Funcionario
    {
        // Atributos privados
        private string? _nome;
        private string? _cpf;
        private DateTime _dataAdmissao;
        private double _salarioBase;

        // Propriedades
        public string? Nome
        {
            get { return _nome; }

            set 
            { 
                _nome = value; 
            }
        }

        public string? CPF
        {
            get { return _cpf; }

            set 
            { 
                _cpf = value; 
            }
        }

        public DateTime DataAdmissao
        {
            get { return _dataAdmissao; }

            set 
            { 
                _dataAdmissao = value; 
            }
        }

        public double SalarioBase
        {
            get { return _salarioBase; }

            set 
            { 
                _salarioBase = value; 
            }
        }
        
        // Construtor
        public Funcionario(string nome, string cpf, DateTime data, double salario)
        {
            Nome = nome;
            CPF = cpf;
            DataAdmissao = data;
            SalarioBase = salario;
        }

        // Métodos virtuais
        public virtual void CalcularSalario() // Salário base = salário final
        {
            Console.WriteLine(SalarioBase);
        }

        public virtual void ExibirDados() // Mostra as informações básicas da pessoa
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Data de admissão: " + DataAdmissao.ToShortDateString());
            Console.WriteLine("Salário: " + SalarioBase);
        }
    }
}
