# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Modelagem:
Foi desenvolvido uma função chamada buscaArq que através da classe File do C#, lê as linhas de um arquivo. Então, no programa principal, o usuário digita uma linha que deseja buscar. A função buscaArq compara a linha digitada pelo usuário com as linhas do arquivo uma a uma, printando quais são iguais e quais são diferentes. No fim, ele mostra quantas linhas foram iguais e quantas foram diferentes.

## Complexidade:
Como o programa faz apenas uma busca comparativa, a operação relevante é a comparação e ela tem complexidade f(n) = n -> O(n) para todos os casos.

## Execução:
<img src=".\imagens\lista7ex1.png">

# Exercício 2:
## Sobre o exercício 2:
No exercício 2 foi dado o seguinte código para análise:
```
static int funcRec1(int a){
            if (a <= 1)
                return 0;
            else
                return funcRec1((a - 2) + 5);
        }
```
## Condições de parada:
O código apresentado acima, trata-se de uma função recursiva que tem como condição de parada, o valor a recebido como parâmetro ser menor ou igual a 1. Caso o valor a inicial seja menor ou igual a esse valor, a chamada recursiva não acontece. Caso seja maior, o programa não vai apresentar uma parada, como veremos a seguir.

## O que a função funcRec1 calcula:
A função não calcula nada, pois ao se inserir valores que não sejam a condição de parada, a mesma faz a chamada recursiva de maneira infinita, gerando um overflow.

## Pilha de execução com a entrada a  = 6
Caso a seja igual a inicial seja igual a 6, o programa fará então a chamada recursiva `funcRec1((6 - 2) + 5)` o que gerará a chamada `funcRec1((9 - 2) + 5)` que gerará a chamada `funcRec1((12 - 2) + 5)` e assim por diante até o overflow.