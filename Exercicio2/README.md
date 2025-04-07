

Exercício 2: Sistema de Gestão de Produtos (Properties)
Objetivo
Criar um sistema de gestão de produtos utilizando diferentes tipos de properties.

Tarefas
Implemente uma classe Produto com:

Properties autoimplementadas (Codigo, Nome)
Properties com validação (Preco, Estoque)
Properties somente leitura (DataCadastro)
Properties calculadas (ValorEmEstoque, Status)
Implemente múltiplos construtores:

Construtor completo
Construtor com atributos essenciais
Construtor padrão (se necessário)
Adicione validações nos setters:

Preço não pode ser negativo
Estoque não pode ser negativo
Nome não pode ser vazio

Cenário de teste:

Crie produtos, demonstre as validações funcionando e exiba as propriedades calculadas.


1) Fiquei um pouco confuso com o fato de precisar ser 'get => _privado' ao invês de 'get;'

2) Foi necessário utilizar de Console.WriteLine pois o throw new Exception aborta o programa;

3) ?
