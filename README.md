Lista de exercícios 02: Programação Orientada a Objetos

Exercício 1: Sistema Bancário (Encapsulamento)
Objetivo: Desenvolver um sistema bancário aplicando os princípios de encapsulamento.
Tarefas:

1.	Crie uma classe ContaBancaria com os seguintes atributos privados:
o	_saldo (decimal)
o	_numeroConta (string)
o	_titular (string)
o	_transacoes (List<Transacao>)

2.	Implemente propriedades somente leitura para:
o	NumeroConta
o	Titular
o	Saldo

3.	Implemente os seguintes métodos públicos:
o	Depositar(decimal valor) - com validação de valor positivo
o	Sacar(decimal valor) - com validação de saldo suficiente
o	VerExtrato() - retorna lista das últimas transações

4.	Crie uma classe Transacao para registrar movimentações com:
o	Data/hora
o	Tipo (enum: Depósito, Saque, Transferência)
o	Valor
o	Descrição

Cenário de teste: Crie contas, realize operações e demonstre como o encapsulamento protege o saldo contra modificações indevidas.
------------------------------------------------------------------------------------------------------
Exercício 2: Sistema de Gestão de Produtos (Properties)
Objetivo: Criar um sistema de gestão de produtos utilizando diferentes tipos de properties.
Tarefas:

1.	Implemente uma classe Produto com:
o	Properties autoimplementadas (Codigo, Nome)
o	Properties com validação (Preco, Estoque)
o	Properties somente leitura (DataCadastro)
o	Properties calculadas (ValorEmEstoque, Status)

2.	Implemente múltiplos construtores:
o	Construtor completo
o	Construtor com atributos essenciais
o	Construtor padrão (se necessário)

3.	Adicione validações nos setters:
o	Preço não pode ser negativo
o	Estoque não pode ser negativo
o	Nome não pode ser vazio

Cenário de teste: Crie produtos, demonstre as validações funcionando e exiba as propriedades calculadas.
------------------------------------------------------------------------------------------------------
Exercício 3: Sistema de RH (Herança)
Objetivo: Desenvolver um sistema de RH explorando hierarquia de classes e herança.
Tarefas:

1.	Crie uma classe base Funcionario com:
o	Propriedades comuns (Nome, CPF, DataAdmissao, SalarioBase)
o	Método virtual CalcularSalario()
o	Método virtual ExibirDados()

2.	Crie as seguintes classes derivadas:
o	Desenvolvedor (com especialidade e nível)
o	Gerente (com equipe e bônus por resultados)
o	Atendente (com meta de atendimentos e comissão)

3.	Sobrescreva os métodos adequadamente em cada classe.

4.	Demonstre o uso de base para chamar a implementação da classe base e estender o comportamento.

Cenário de teste: Crie diferentes tipos de funcionários e processe a folha de pagamento mostrando o polimorfismo em ação.
------------------------------------------------------------------------------------------------------
Exercício 4: Sistema de Pagamentos (Polimorfismo)
Objetivo: Implementar um sistema de pagamentos explorando o polimorfismo em diferentes formas.
Tarefas:

1.	Crie uma classe abstrata Pagamento com:
o	Propriedades comuns (Valor, Data, Status)
o	Método abstrato Processar()
o	Método abstrato GerarRecibo()

2.	Crie classes derivadas para diferentes métodos de pagamento:
o	PagamentoCartao (com bandeira, número, parcelas)
o	PagamentoBoleto (com código de barras, data vencimento)
o	PagamentoPix (com chave, QRCode)

3.	Implemente um ProcessadorPagamento que:
o	Recebe qualquer tipo de Pagamento
o	Chama o método Processar() polimorficamente
o	Registra informações de auditoria

4.	Implemente também sobrecarga de métodos (polimorfismo em tempo de compilação).

Cenário de teste: Processe diferentes tipos de pagamento através da mesma interface.
------------------------------------------------------------------------------------------------------
Exercício 5: Sistema de Notificações (Interfaces)
Objetivo: Criar um sistema de notificações baseado em interfaces.
Tarefas:

1.	Defina uma interface INotificador com:
o	EnviarNotificacao(string destinatario, string mensagem)
o	ValidarDestinatario(string destinatario)
o	Propriedade FormatoSuportado (get)

2.	Implemente classes concretas:
o	NotificadorEmail
o	NotificadorSMS
o	NotificadorPush

3.	Crie uma classe GerenciadorNotificacoes que:
o	Pode registrar múltiplos notificadores
o	Envia mensagens através de todos os canais registrados
o	Seleciona o canal apropriado com base no tipo de mensagem

4.	Crie duas interfaces com método de mesmo nome e implemente-as explicitamente em uma classe.

Cenário de teste: Configure diferentes notificadores e envie mensagens demonstrando o polimorfismo através de interfaces.
------------------------------------------------------------------------------------------------------
Exercício 6: Sistema de Armazenamento (Interfaces vs Classes Abstratas)
Objetivo: Explorar as diferenças entre interfaces e classes abstratas.
Tarefas:

1.	Defina uma interface IArmazenamento com métodos básicos:
o	Salvar(string arquivo, byte[] dados)
o	Carregar(string arquivo)
o	Excluir(string arquivo)
o	Listar()

2.	Crie uma classe abstrata ArmazenamentoBase que:
o	Implementa a interface IArmazenamento
o	Fornece implementações padrão para operações comuns
o	Contém métodos abstratos para operações específicas
o	Inclui campos e métodos protegidos

3.	Implemente classes concretas:
o	ArmazenamentoLocal (herda da classe abstrata)
o	ArmazenamentoNuvem (herda da classe abstrata)
o	ArmazenamentoMemoria (implementa apenas a interface)

4.	Compare as abordagens documentando vantagens e desvantagens.

Cenário de teste: Demonstre como o código cliente pode trabalhar com as abstrações.
------------------------------------------------------------------------------------------------------
Exercício 7: Gerenciador de Recursos (IDisposable)
Objetivo: Implementar o padrão Disposable para gerenciamento correto de recursos.

Tarefas:
1.	Crie uma classe GerenciadorConexaoBD que:
o	Simula uma conexão com banco de dados
o	Implementa IDisposable corretamente
o	Possui um finalizador
o	Inclui métodos para executar consultas

2.	Implemente o padrão Disposable completo com:
o	Dispose() público
o	Dispose(bool) protegido
o	Finalizador
o	Flag para evitar múltiplas disposições

3.	Adicione uma hierarquia de classes disposable:
o	Classe base RecursoBase
o	Classes derivadas que gerenciam recursos adicionais

4.	Use adequadamente GC.SuppressFinalize(this).

Cenário de teste: Demonstre o uso correto com blocos using e o comportamento em caso de exceções.
------------------------------------------------------------------------------------------------------
Exercício 8: Projeto Integrado - Sistema de E-commerce
Objetivo: Desenvolver um sistema integrado aplicando todos os conceitos estudados.

Tarefas:
1.	Implemente um sistema de e-commerce com as seguintes partes:
o	Catálogo de Produtos
	Hierarquia de produtos com classe abstrata base
	Classes derivadas para diferentes categorias
	Métodos polimórficos para cálculo de preço e imposto
o	Carrinho de Compras
	Gerencia itens de diversos tipos
	Calcula total usando polimorfismo
	Implementa interface para serialização
o	Sistema de Pagamento
	Interfaces para diferentes processadores
	Gestão adequada de recursos externos (IDisposable)
	Polimorfismo para tratamento unificado
o	Notificação de Clientes
	Interface de notificação
	Múltiplas implementações (email, SMS, push)
	Uso correto de injeção de dependência

2.	Integre todos os componentes demonstrando:
o	Encapsulamento
o	Herança e polimorfismo
o	Uso de interfaces
o	Gerenciamento adequado de recursos

Cenário de teste: Crie um fluxo completo de compra, do catálogo ao pagamento e notificação.
------------------------------------------------------------------------------------------------------

Instruções para Entrega
Para cada exercício:
1.	Implemente o código seguindo os princípios de POO e as boas práticas de C#
2.	Inclua comentários explicando decisões de design importantes
3.	Adicione um programa principal demonstrando o funcionamento
4.	Prepare uma breve documentação (1-2 páginas) explicando: 
o	Arquitetura da solução
o	Princípios de POO aplicados
o	Desafios encontrados e como foram resolvidos
Prazo de entrega: 08/04/2025
Forma de entrega: Repositório Git organizado com uma pasta por exercício

