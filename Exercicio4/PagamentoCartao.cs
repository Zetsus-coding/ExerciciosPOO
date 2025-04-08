using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class PagamentoCartao : Pagamento
    {
        // Campo(?)
        private string? _numero;
        private int _parcelas;

        // Propriedade
        public string? Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public int Parcelas 
        { 
            get { return _parcelas; } 
            set { _parcelas = value; } 
        }

        // Enum
        public enum EnumBandeira
        {
            MasterCard,
            Visa,
            Elo,
            AmericanExpress
        }

        public EnumBandeira Bandeira { get; set; }

        // Construtor
        //public PagamentoCartao()
        //{ 
        //}

        // Métodos
        public override void Processar()
        {
            Status = "Processado";
            Console.WriteLine("Pagamento com cartão processado com sucesso.");
        }

        public override void GerarRecibo()
        {
            Console.WriteLine("Recibo gerado com sucesso, para o pagamento feito com cartão.");
        }
    }
}
