Exercício 1: Sistema Bancário (Encapsulamento)
Objetivo
Desenvolver um sistema bancário aplicando os princípios de encapsulamento.

Tarefas
Crie uma classe ContaBancaria com os seguintes atributos privados:

_saldo (decimal)
_numeroConta (string)
_titular (string)
_transacoes (List)
Implemente propriedades somente leitura para:

NumeroConta
Titular
Saldo
Implemente os seguintes métodos públicos:

Depositar(decimal valor) - com validação de valor positivo
Sacar(decimal valor) - com validação de saldo suficiente
VerExtrato() - retorna lista das últimas transações
Crie uma classe Transacao para registrar movimentações com:

Data/hora
Tipo (enum: Depósito, Saque, Transferência)
Valor
Descrição

Cenário de teste:

Crie contas, realize operações e demonstre como o encapsulamento protege o saldo contra modificações indevidas.
