using System;

namespace Exercicio1
{
    public enum TipoTransacao
    {
        Deposito,
        Saque,
        Transferencia
    }

    public class Transacao
    {
        // Propriedades somente leitura
        public DateTime Data { get; }
        public TipoTransacao Tipo { get; }
        public decimal Valor { get; }
        public string Descricao { get; }

        // Construtor
        public Transacao(DateTime data, TipoTransacao tipo, decimal valor, string descricao)
        {
            Data = data;
            Tipo = tipo;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
