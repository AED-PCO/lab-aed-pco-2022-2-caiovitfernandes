# Funcionamento do LAB9:
Como o LAB9 trata-se de um complemento do LAB8, o mesmo foi desenvolvido em um projeto separado, mas o Program do mesmo foi copiado e criado como um arquivo .cs dentro do LAB8

## Copiar uma fila invertendo sua ordem: 
Para solução deste exercício, foi criado um método void que recebe como parâmetros duas filas e uma referência. O método então utiliza uma pilha auxiliar empilhando nela o que é removido da fila, invertendo assim sua ordem. Então, uma outra estrutura de repetição desempilha os itens da pilha passando para ambas as filas, invertendo assim sua ordem.

<img src=".\imagens\lista9ex1.png">

## Copiar uma pilha mantendo sua ordem:
Para solução deste exercício, foi criado um método void que recebe como parâmetros duas pilhas e uma referência. O método então usa uma pilha auxiliar para desempilhar a pilha 1, invertendo sua ordem. Então, outra estrutura de repetição é acionada para desempilhar a fila auxiliar, copiando valor por valor e empilhando esse valor nas pilhas 1 e 2.

<img src=".\imagens\lista9ex2.png">