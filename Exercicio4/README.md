Exercício 4: Sistema de Pagamentos (Polimorfismo)
Objetivo
Implementar um sistema de pagamentos explorando o polimorfismo em diferentes formas.

Tarefas
Crie uma classe abstrata Pagamento com:

Propriedades comuns (Valor, Data, Status)
Método abstrato Processar()
Método abstrato GerarRecibo()
Crie classes derivadas para diferentes métodos de pagamento:

PagamentoCartao (com bandeira, número, parcelas)
PagamentoBoleto (com código de barras, data vencimento)
PagamentoPix (com chave, QRCode)
Implemente um ProcessadorPagamento que:

Recebe qualquer tipo de Pagamento
Chama o método Processar() polimorficamente
Registra informações de auditoria
Implemente também sobrecarga de métodos (polimorfismo em tempo de compilação).

Cenário de teste:

Processe diferentes tipos de pagamento através da mesma interface.
