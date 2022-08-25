# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo: Número = 3025. Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . A soma de 30 com 25 é igual a 55 O Quadrado de 55 é igual a 3025. Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

Para resolução, o programa parte do preceito de que dividindo um número de 4 algarismos por 100, podemos pegar os dois primeiros algarismos, e fazendo a operação de mod (%), podemos pegar os dois algarismos restantes. Depois o programa soma esses dois resultados, eleva ao quadrado e verifica se é igual ao número de entrada. 

Entradas: Com um for, o programa fornece como entrada para a função, todos os números de 1000 a 9999.
Saídas: 
2025
3025
9801

<img src=".\imagens\lista1ex1.png">

# Exercício 2:
## Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele. Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.

Para resulução, foi necessário criar um método booleano que utiliza um for para dividir o número por todos os seus antecessores (até 2), verificando se o mod (%) dessas divisões resulta em 0. Se sim, ele retorna como falso, pois o número não é primo. Se não, ele retorna verdadeiro.

Entradas de Exemplo:
10
11
43

Saídas:
10 não é primo
11 é primo
43 é primo

## Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6. Faça um programa que liste os números perfeitos de 1 a 1000.

Para resolução deste, foi implementado um for que percorre por todos os antecessores do número, descobrindo pela operação mod (%), se são dividores do número. Caso fosse divisor, uma variável auxiliar recebia esse número somando de maneira acumulativa. No fim, o programa compara a soma dos divisores com o próprio numero.

Entradas: Um for percorrendo os números de 1 a 1000
Saídas: Os números perfeitos de 1 a 1000 são:
6
28
496

# Exercício 3:
## Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos. Crie um vetor resultante C que possua os elementos comuns entre A e B. Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Para resolução deste exercício, foram criados quatro vetores. Dois para receber as entradas dos usuários e dois para receberem as saídas do programa. O programa usa dois for's, um dentro do outro, para percorrer ambos os vetores. Os for's então comparam item a item de um vetor no outro e caso encontre itens iguais salva em um dos vetores de saída. Caso não encontre, salva no outro vetor de saída.

Entradas exemplo:
1
2
3
4
5
2
4
6
8
0

Saídas:
Sejam os vetores 
a = 1, 2, 3, 4, 5 e
b = 2, 4, 6, 8, 0.
Os números em comum são: 2, 4, 0, 0, 0
e os números de a que não estão em b: 1, 3, 5, 0, 0

# Exercício 4:
## Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Para resolução deste exercício foram desenvolvidos dois métodos. Um que recebe uma matriz e a coluna a ser somada e retorna a soma. E outro que recebe uma matriz e a linha a ser somada e retorna a soma. Em seguida, foram criados dois for's. Um para percorrer as colunas da matriz invocando o método de soma de colunas e o outro para percorrer as linhas invocando o método de soma de linhas.

Entradas Exemplo: Um for para ler os 15 números do usuário e montar uma matriz
1
2
3
4
5
6
7
8
9
0
11
12
13
14
15

Saída: 
Matriz:
1 2 3
4 5 6
7 8 9
0 11 12
13 14 15

Soma da linha 1: 6
Soma da linha 2: 15
Soma da linha 3: 24
Soma da linha 4: 23
Soma da linha 5: 42
Soma da Coluna 1: 25
Soma da Coluna 2: 40
Soma da Coluna 3: 45

# Exercício 5:
## Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Na resolução deste exercício, foi desenvolvido um método recursivo que tem como condição de parada passar um número menor que 1. Neste caso ele retorna 1, caso contrário, o método faz a chamada recursiva passando N-1 como parâmetro e multiplicando os desempilhamentos.

Entrada Exemplo: 7
Saída: 5040

# Exercício 6:
## Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

Nesse exercício foi criado um método que recebe duas referências de inteiros. Ele então salva o primeiro valor em uma variável auxiliar e em seguida percorre um for de 1 até o segundo número passado. A cada iteração o primeiro número é multiplicado pela variável aux e é retornado no fim.

Entrada Exemplo:
3
^
3
Saída: 27
