# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Classes Aluno e Elemento
Para solução de todos os exercícios, foram implementadas duas classes. Uma chamada aluno, para receber os valores que serão armazenados na estrutura, que são o nome, matrícula e nota. A outra, elemento. Esta última tem como atributos um aluno do tipo aluno, e um ponteiro chamado próximo do tipo elemento.

# Mostrar as estruturas
Para todas as estruturas, o método de mostrar foi o mesmo. Um método que recebe o primeiro e o último elemento como parâmetros (referências para eles) e então percorre toda a estrutura mostrando um a um.

# Pilha Dinâmica:
## Inserção:
Para inserir na pilha dinâmica, foi criado um método que recebe como parâmetro um ponteiro para o último elemento e um novo elemento para ser inserido.
O método então utiliza-se do ponteiro ultimo para acessar o último elemento e apontar seu ponteiro próximo para o elemento novo.

<img src=".\imagens\lista10ex1I.png">

## Remoção:
Para remover na pilha dinâmica, foi criado um método que recebe como parâmetro um ponteiro para o último elemento e um ponteiro para o primeiro elemento.
O método então utiliza-se do ponteiro ultimo para acessar o último elemento e salva-o para ser retornado. Logo em seguida, o método percorre toda a estrutura a partir do primeiro elemento até encontrar o penultimo. Então, o método atualiza o ponteiro de último para a penúltima posição e retorna o que estava na variável auxiliar.

<img src=".\imagens\lista10ex1R.png">

# Fila Dinâmica:
## Inserção:
Para inserir na fila dinâmica, foi criado um método que recebe como parâmetros um ponteiro para o último elemento e o novo elemento que será inserido.
O método de inserção segue-se idêntico à inserção na pilha.

<img src=".\imagens\lista10ex2I.png">

## Remoção:
Para remover na fila dinâmica, foi criado um método que recebe como parâmetros um ponteiro para o último elemento e um ponteiro para o primeiro elemento. 
Então o método acessa o primeiro elemento e salva em um auxiliar para ser retornado. Em seguida, o método faz o primeiro (sentinela) apontar para o segundo elemento. E então retorna o elemento que está no auxiliar.
<img src=".\imagens\lista10ex2R.png">

# Lista Dinâmica:
## Inserção:
Para inserir na lista dinâmica, foi criado um método que recebe como parâmetros um ponteiro para o último elemento, um ponteiro para o primeiro elemento, o novo elemento a ser inserido e a posição em que se deseja inserir. Em seguida, o método verifica se a posição a ser inserida está no meio da lista. Caso sim, ele então percorre a lista a partir do primeiro e faz as novas conexões dos ponteiros com o novo elemento. Caso não, ele insere na última posição, idêntico ao processo da pilha e da lista.
<img src=".\imagens\lista10ex3I.png">

## Remoção:
Para remover na lista dinâmica, foi criado um método que recebe como parâmetros um ponteiro para o último elemento e um ponteiro para o primeiro elemento, e a posição em que se deseja remover.
Então o método verifica se a posição existe na lista passando pela lista. Caso sim, são feitas as desconexões de ponteiros para retornar o elemento removido. Caso não, retorna um elemento vazio.


<img src=".\imagens\lista10ex3R.png">
