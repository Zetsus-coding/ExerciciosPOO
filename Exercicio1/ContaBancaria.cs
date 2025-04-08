using System;

namespace Exercicio1
{
    public class ContaBancaria
    { 
	    // Atributos privados
        private decimal _saldo;
        private string _numeroConta;
        private string _titular;
        private List<Transacao> _transacoes;

        // Propriedades somente leitura
        public string NumeroConta { get; }
        public string Titular { get; }
        public decimal Saldo { get; }
        
        // Construtor
        public ContaBancaria(string numeroConta, string titular)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = 0.0m;
            _transacoes = new List<Transacao>();
        }

        // Métodos
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
               Console.WriteLine("Inválido! O valor do depósito deve ser positivo");
            }
            else // valor > 0
            {
                _saldo += valor;
                _transacoes.Add(new Transacao(DateTime.Now, TipoTransacao.Deposito, valor, "Depósito efetuado"));
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
            else // valor > 0 e valor < saldo
            { 
                _saldo -= valor;
                _transacoes.Add(new Transacao(DateTime.Now, TipoTransacao.Saque, valor, "Saque efetuado"));
            }
        }

        public List<Transacao> VerExtrato()
        {
            if(_transacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma transação efetuada");
                return new List<Transacao>(_transacoes);
            }
            else 
            { 
                return new List<Transacao>(_transacoes);
            }
        }
    }
}



