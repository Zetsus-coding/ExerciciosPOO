Exerc�cio 1: Sistema Banc�rio (Encapsulamento)
Objetivo
Desenvolver um sistema banc�rio aplicando os princ�pios de encapsulamento.

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
Implemente os seguintes m�todos p�blicos:

Depositar(decimal valor) - com valida��o de valor positivo
Sacar(decimal valor) - com valida��o de saldo suficiente
VerExtrato() - retorna lista das �ltimas transa��es
Crie uma classe Transacao para registrar movimenta��es com:

Data/hora
Tipo (enum: Dep�sito, Saque, Transfer�ncia)
Valor
Descri��o

Cen�rio de teste:

Crie contas, realize opera��es e demonstre como o encapsulamento protege o saldo contra modifica��es indevidas.
