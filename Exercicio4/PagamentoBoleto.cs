using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class PagamentoBoleto : Pagamento
    {
        // Campo(?) c/ encapsulamento(?)
        private string? _codigoBarras;
        private string? _dataVencimento;

        // Propriedade
        public string? CodigoBarras
        {
            get { return _codigoBarras; }
            set { _codigoBarras = value; }
        }
        public string? DataVencimento
        {
            get { return _dataVencimento; }
            set { _dataVencimento = value; }
        }

        // Métodos
        public override void Processar()
        {
            Status = "Processado";
            Console.WriteLine("Pagamento com boleto processado com sucesso.");
        }

        public override void GerarRecibo()
        {
            Console.WriteLine("Recibo gerado com sucesso, para o pagamento feito com boleto.\n");
            Console.WriteLine(" ----- BOLETO ----- ");
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Data do pagamento: " + Data);
            Console.WriteLine("Código: " + DataVencimento + "\n");
            Console.WriteLine("Status atual: " + Status);
            Console.WriteLine(" ------- // ------- ");
        }
    }
}
