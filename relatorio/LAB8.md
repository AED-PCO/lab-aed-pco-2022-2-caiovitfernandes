# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Estrutura de fila:
Para elaboração desta estrutura, criou-se uma classe chamada fila, que tinha como funções: inserir, remover e mostrar.

## Inserir na fila:
Para o método de inserção, criou-se um método void que recebe o vetor e a referência que aponta para a última posição livre da fila. Então, o método salva o valor na posição de referência do vetor e incrementa a referência.
<img src=".\imagens\lista8ex1I.png">

## Remover na fila:
Para o método de remoção na fila, criou-se uma função do tipo int que recebe o vetor e a referência que aponta para a última posição da fila. Então, a função salva o primeiro valor do vetor [0], em uma variavel auxiliar. Depois a função chama um método chamado <i>Shift</i> que desloca todos os valores da fila para a esquerda. Em seguida, a função decrementa a referência e retorna o valor da variavel auxiliar.
<img src=".\imagens\lista8ex1R.png">

### O método shift:
Para solucionar alguns métodos desta lista de exercícios, foi necessário o desenvolvimento de um método que desloca os valores em um vetor para a esquerda ou para a direita dependendo na necessidade. O método encontra-se a seguir:
```
public static void shift(int[] vetor, int inicio, int fim, string sentido){
    if(sentido == "esquerda"){
        for(int i = inicio; i <= fim; i++){
            vetor[i - 1] = vetor[i];
        }
    }
    else if(sentido == "direita"){
        for(int i = fim; i >= inicio; i--){
            vetor[i + 1] = vetor[i];
        }
    }
}
```
## Mostrar a fila:
Para mostrar a fila, foi necessário o desenvolvimento de um método do tipo void que recebe o vetor e a referência da última posição vaga na fila. Então a função executa um for que sera iterado de acordo com o valor da referencia - 1. Dentro deste for, é chamado primeiro a função de remoção e o que é retornado dela é mandado para a função de inserção. Este valor é então mostrado na tela.
<img src=".\imagens\lista8ex1M.png">

# Estrutura de pilha:
Para elaboração desta estrutura, criou-se uma classe chamada pilha, que tinha como funções: inserir, remover e mostrar.

## Inserir na pilha:
Para o método de inserção, criou-se um método void que recebe o vetor e a referência que aponta para a última posição livre da fila. Então, o método salva o valor na posição de referência do vetor e incrementa a referência.
<img src=".\imagens\lista8ex2I.png">

## Remover na pilha:
Para o método de remoção na pilha, criou-se uma função do tipo int que recebe o vetor e a referência que aponta para a última posição da fila. Então, a função decrementa a referência e retorna o vetor na posição da referência.
<img src=".\imagens\lista8ex1R.png">

## Mostrar a pilha
Para mostrar a pilha, foi necessário a criação de um método void que recebe o vetor e o valor da referência como parâmetros. Então, o método remove um a um dos itens do vetor, passando-os para um vetor auxiliar e mostrando-os na tela. Em seguida os itens são inseridos um a um novamente na pilha
<img src=".\imagens\lista8ex2M.png">

# Estrutura de lista
Para elaboração desta estrutura, criou-se uma classe chamada lista, que tinha como funções: inserir, remover e mostrar.

## Inserir na lista:
Para o método de inserção, criou-se um método void que recebe o vetor, um valor, uma posição e a referência que aponta para a última posição livre da lista. Então, o método verifica se a posição passada é uma posição válida. Então, caso seja maior que a referência ou a própria referência, o valor é inserido na última posição livre e a referência é incrementada. Se é menor que a referência, é feito um shift para a direita para liberar o espaço na posição, o valor é inserido na posição e a referência é incrementada.
<img src=".\imagens\lista8ex3I.png">

## Remover na lista
Para o método de remoção na lista, criou-se uma função do tipo int que recebe o vetor, a referência que aponta para a última posição da fila, e uma posição. Então, a função retorna o valor da posição passada e faz um shift para a esquerda para remover a posição da lista e decrementa a referência.
<img src=".\imagens\lista8ex3R.png">

## Mostrar a lista
Para mostrar a lista, foi necessário o desenvolvimento de um método do tipo void que recebe o vetor e a referência da última posição vaga na lista. Então, o método passa um for mostrando todos os valores na lista.
<img src=".\imagens\lista8ex3M.png">

