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
        public Funcionario()
        {
            // Devo sempre inicializar?
        }

        // Métodos virtuais
        public virtual void CalcularSalario()
        {
            Console.WriteLine(SalarioBase);
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Data de admissão: " + DataAdmissao.ToShortDateString());
            Console.WriteLine("Salário: " + SalarioBase);
        }


    }
}
