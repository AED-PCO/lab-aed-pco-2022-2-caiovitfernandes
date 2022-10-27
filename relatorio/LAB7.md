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

## Execução:
<img src=".\imagens\lista7ex2.png">

# Exercício 3:
## Modelagem:
Foram desenvolvidas duas funções: uma que, a partir da classe File do C#, le a primeira linha do arquivo entrada.txt, inverte a string desta linha e retorna ela invertida. A outra função, através da classe StreamWriter, importada da biblioteca System.IO, salva uma linha em um arquivo. Então o programa principal pega o retorno da função que lê e inverte e usa a função que salva para salvar a string invertida no arquivo Saida.txt.

## Complexidade:
Tanto a operação de leitura, quanto a operação de escrita têm complexidade O(1) e portanto, a operação relevante está relacionada ao processo de inversão da string, pois varia de acordo com o tamanho "n" da string que está escrita na primeira linha do arquivo. Sendo assim, a operação mais relevante é a operação de atribuição que tem função de complexidade f(n) = n -> O(n) para todos os casos.

## Execução:
<img src=".\imagens\lista7ex3.png">

# Exercício 4:
## Sobre o exercício 4:
No exercício 4 foi passado uma situação hipotética onde um especialista de TI sugeriu para um banco famoso a ordenação de sua base de dados por meio do algoritmo insertion Sort para ordenar via CPF's.

## A escolha do algoritmo feita pelo especialista foi boa? 
Não, o insertion sort é uma bom método de ordenação quando se inicia um banco de dados vazio ou com poucos registros e deseja-se inserir os registros de maneira ordenada. Porém, quando se tem um banco de dados já montado e com muitos registros, como é o caso da base de dados de um banco famoso, o insertion sort tem uma complexidade elevada nos piores casos.

## Algoritmo de ordenação sugerido:
Para o caso apresentado, o algoritmo mais adequado seria algum algoritmo que use a estratégia de divisão por conquista. Para o caso em questão, os melhores poderiam ser o merge sort ou o quick sort. Como se trata de uma base de dados muito extensa e com valores que não se repetem, o quick sort seria o algoritmo mais adequado por possuir um menor tempo despendido na ordenação. 

## Viabilidade do Quick Sort
Nos testes de execução do algoritmo, utilizando a biblioteca System.Diagnostics para calcular o tempo de execução, a resposta obtida foi algo entre 12 e 15 milisegundos para ordenar uma base de dados com 50.000 CPF's, como será demonstrado no print da execução a seguir.

## Execução:
<img src=".\imagens\lista7ex4.png">

# Exercício 5:
# Sobre o exercício 5:
No exercício 5, foi disponibilizado o seguinte código para análise:
```
static int funcao(int a, int[] v){
            if(a == 1)
                return v[0];
            else{
                int x;
                x = funcao(a - 1, v);
                if(x > v[a - 1])
                    return x;
                else
                    return v[a - 1];
            }
        }
```

## O que é retornado pela função no caso de passar os parâmetros v = {10, 5, 7, 15, 22, 9, 30} e a = 6:
Tem-se que com esses parâmetros, a função fará, inicialmente a chamada recursiva `x = funcao(6 - 1, v)`;
e então essa chamada chegaria na chamada `x = funcao(5 - 1, v)` -> `x = funcao(4 - 1, v)` -> `x = funcao(3 - 1, v)` -> `x = funcao(2 - 1, v)` e essa chamada, como passa a = 1, cai na condição de parada que retorna `v[0] = 10` para o x<sub>5</sub>. O x<sub>5</sub> então continua a função até que no bloco
```
if(x > v[a - 1])
    return x;
else
    return v[a - 1];
```
retorna 10 para o x<sub>4</sub>. O x<sub>4</sub>, ao chegar nesse mesmo bloco, retorna 10 para o x<sub>3</sub>. o x<sub>3</sub> ao chegar nesse mesmo bloco retorna 10 para o x<sub>2</sub>. O x<sub>2</sub> ao chegar nesse mesmo bloco retorna 10 para o x<sub>1</sub>. O x<sub>1</sub> ao chegar nesse mesmo bloco retorna **22** para o algoritmo que chamou a função inicialmente.

## Execução:
<img src=".\imagens\lista7ex5.png">

