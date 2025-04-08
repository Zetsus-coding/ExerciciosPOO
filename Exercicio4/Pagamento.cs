using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal abstract class Pagamento
    {
        // Propriedades
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string? Status { get; set; }

        // Métodos abstratos
        public abstract void Processar();
        public abstract void GerarRecibo();
    }
}
