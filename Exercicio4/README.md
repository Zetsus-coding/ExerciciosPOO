Exerc�cio 4: Sistema de Pagamentos (Polimorfismo)
Objetivo
Implementar um sistema de pagamentos explorando o polimorfismo em diferentes formas.

Tarefas
Crie uma classe abstrata Pagamento com:

Propriedades comuns (Valor, Data, Status)
M�todo abstrato Processar()
M�todo abstrato GerarRecibo()
Crie classes derivadas para diferentes m�todos de pagamento:

PagamentoCartao (com bandeira, n�mero, parcelas)
PagamentoBoleto (com c�digo de barras, data vencimento)
PagamentoPix (com chave, QRCode)
Implemente um ProcessadorPagamento que:

Recebe qualquer tipo de Pagamento
Chama o m�todo Processar() polimorficamente
Registra informa��es de auditoria
Implemente tamb�m sobrecarga de m�todos (polimorfismo em tempo de compila��o).

Cen�rio de teste:

Processe diferentes tipos de pagamento atrav�s da mesma interface.
