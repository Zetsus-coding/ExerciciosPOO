# Lista de Exercícios 02: Programação Orientada a Objetos

## Exercício 1: Sistema Bancário (Encapsulamento)

### Objetivo
Desenvolver um sistema bancário aplicando os princípios de encapsulamento.

### Tarefas

1. Crie uma classe `ContaBancaria` com os seguintes atributos privados:
    - `_saldo` (decimal)
    - `_numeroConta` (string)
    - `_titular` (string)
    - `_transacoes` (List<Transacao>)

2. Implemente propriedades somente leitura para:
    - `NumeroConta`
    - `Titular`
    - `Saldo`

3. Implemente os seguintes métodos públicos:
    - `Depositar(decimal valor)` - com validação de valor positivo
    - `Sacar(decimal valor)` - com validação de saldo suficiente
    - `VerExtrato()` - retorna lista das últimas transações

4. Crie uma classe `Transacao` para registrar movimentações com:
    - Data/hora
    - Tipo (enum: Depósito, Saque, Transferência)
    - Valor
    - Descrição

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Crie contas, realize operações e demonstre como o encapsulamento protege o saldo contra modificações indevidas.

</p>
</details>

---

## Exercício 2: Sistema de Gestão de Produtos (Properties)

### Objetivo
Criar um sistema de gestão de produtos utilizando diferentes tipos de properties.

### Tarefas

1. Implemente uma classe `Produto` com:
    - Properties autoimplementadas (`Codigo`, `Nome`)
    - Properties com validação (`Preco`, `Estoque`)
    - Properties somente leitura (`DataCadastro`)
    - Properties calculadas (`ValorEmEstoque`, `Status`)

2. Implemente múltiplos construtores:
    - Construtor completo
    - Construtor com atributos essenciais
    - Construtor padrão (se necessário)

3. Adicione validações nos setters:
    - Preço não pode ser negativo
    - Estoque não pode ser negativo
    - Nome não pode ser vazio

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Crie produtos, demonstre as validações funcionando e exiba as propriedades calculadas.

</p>
</details>

---

## Exercício 3: Sistema de RH (Herança)

### Objetivo
Desenvolver um sistema de RH explorando hierarquia de classes e herança.

### Tarefas

1. Crie uma classe base `Funcionario` com:
    - Propriedades comuns (`Nome`, `CPF`, `DataAdmissao`, `SalarioBase`)
    - Método virtual `CalcularSalario()`
    - Método virtual `ExibirDados()`

2. Crie as seguintes classes derivadas:
    - `Desenvolvedor` (com especialidade e nível)
    - `Gerente` (com equipe e bônus por resultados)
    - `Atendente` (com meta de atendimentos e comissão)

3. Sobrescreva os métodos adequadamente em cada classe.

4. Demonstre o uso de `base` para chamar a implementação da classe base e estender o comportamento.

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Crie diferentes tipos de funcionários e processe a folha de pagamento mostrando o polimorfismo em ação.

</p>
</details>

---

## Exercício 4: Sistema de Pagamentos (Polimorfismo)

### Objetivo
Implementar um sistema de pagamentos explorando o polimorfismo em diferentes formas.

### Tarefas

1. Crie uma classe abstrata `Pagamento` com:
    - Propriedades comuns (`Valor`, `Data`, `Status`)
    - Método abstrato `Processar()`
    - Método abstrato `GerarRecibo()`

2. Crie classes derivadas para diferentes métodos de pagamento:
    - `PagamentoCartao` (com bandeira, número, parcelas)
    - `PagamentoBoleto` (com código de barras, data vencimento)
    - `PagamentoPix` (com chave, QRCode)

3. Implemente um `ProcessadorPagamento` que:
    - Recebe qualquer tipo de `Pagamento`
    - Chama o método `Processar()` polimorficamente
    - Registra informações de auditoria

4. Implemente também sobrecarga de métodos (polimorfismo em tempo de compilação).

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Processe diferentes tipos de pagamento através da mesma interface.

</p>
</details>

---

## Exercício 5: Sistema de Notificações (Interfaces)

### Objetivo
Criar um sistema de notificações baseado em interfaces.

### Tarefas

1. Defina uma interface `INotificador` com:
    - `EnviarNotificacao(string destinatario, string mensagem)`
    - `ValidarDestinatario(string destinatario)`
    - Propriedade `FormatoSuportado` (get)

2. Implemente classes concretas:
    - `NotificadorEmail`
    - `NotificadorSMS`
    - `NotificadorPush`

3. Crie uma classe `GerenciadorNotificacoes` que:
    - Pode registrar múltiplos notificadores
    - Envia mensagens através de todos os canais registrados
    - Seleciona o canal apropriado com base no tipo de mensagem

4. Crie duas interfaces com método de mesmo nome e implemente-as explicitamente em uma classe.

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Configure diferentes notificadores e envie mensagens demonstrando o polimorfismo através de interfaces.

</p>
</details>

---

## Exercício 6: Sistema de Armazenamento (Interfaces vs Classes Abstratas)

### Objetivo
Explorar as diferenças entre interfaces e classes abstratas.

### Tarefas

1. Defina uma interface `IArmazenamento` com métodos básicos:
    - `Salvar(string arquivo, byte[] dados)`
    - `Carregar(string arquivo)`
    - `Excluir(string arquivo)`
    - `Listar()`

2. Crie uma classe abstrata `ArmazenamentoBase` que:
    - Implementa a interface `IArmazenamento`
    - Fornece implementações padrão para operações comuns
    - Contém métodos abstratos para operações específicas
    - Inclui campos e métodos protegidos

3. Implemente classes concretas:
    - `ArmazenamentoLocal` (herda da classe abstrata)
    - `ArmazenamentoNuvem` (herda da classe abstrata)
    - `ArmazenamentoMemoria` (implementa apenas a interface)

4. Compare as abordagens documentando vantagens e desvantagens.

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Demonstre como o código cliente pode trabalhar com as abstrações.

</p>
</details>

---

## Exercício 7: Gerenciador de Recursos (IDisposable)

### Objetivo
Implementar o padrão Disposable para gerenciamento correto de recursos.

### Tarefas

1. Crie uma classe `GerenciadorConexaoBD` que:
    - Simula uma conexão com banco de dados
    - Implementa `IDisposable` corretamente
    - Possui um finalizador
    - Inclui métodos para executar consultas

2. Implemente o padrão Disposable completo com:
    - `Dispose()` público
    - `Dispose(bool)` protegido
    - Finalizador
    - Flag para evitar múltiplas disposições

3. Adicione uma hierarquia de classes disposable:
    - Classe base `RecursoBase`
    - Classes derivadas que gerenciam recursos adicionais

4. Use adequadamente `GC.SuppressFinalize(this)`.

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Demonstre o uso correto com blocos `using` e o comportamento em caso de exceções.

</p>
</details>

---

## Exercício 8: Projeto Integrado - Sistema de E-commerce

### Objetivo
Desenvolver um sistema integrado aplicando todos os conceitos estudados.

### Tarefas

1. Implemente um sistema de e-commerce com as seguintes partes:
    - Catálogo de Produtos
        - Hierarquia de produtos com classe abstrata base
        - Classes derivadas para diferentes categorias
        - Métodos polimórficos para cálculo de preço e imposto
    - Carrinho de Compras
        - Gerencia itens de diversos tipos
        - Calcula total usando polimorfismo
        - Implementa interface para serialização
    - Sistema de Pagamento
        - Interfaces para diferentes processadores
        - Gestão adequada de recursos externos (`IDisposable`)
        - Polimorfismo para tratamento unificado
    - Notificação de Clientes
        - Interface de notificação
        - Múltiplas implementações (email, SMS, push)
        - Uso correto de injeção de dependência

2. Integre todos os componentes demonstrando:
    - Encapsulamento
    - Herança e polimorfismo
    - Uso de interfaces
    - Gerenciamento adequado de recursos

<details>
<summary><strong>Cenário de teste</strong></summary>
<p>

Crie um fluxo completo de compra, do catálogo ao pagamento e notificação.

</p>
</details>

---

## Instruções para Entrega

Para cada exercício:

1. Implemente o código seguindo os princípios de POO e as boas práticas de C#.
2. Inclua comentários explicando decisões de design importantes.
3. Adicione um programa principal demonstrando o funcionamento.
4. Prepare uma breve documentação (1-2 páginas) explicando: 
    - Arquitetura da solução
    - Princípios de POO aplicados
    - Desafios encontrados e como foram resolvidos

**Prazo de entrega:** 08/04/2025

**Forma de entrega:** Repositório Git organizado com uma pasta por exercício.
