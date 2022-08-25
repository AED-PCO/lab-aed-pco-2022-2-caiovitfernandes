# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Escreva um método recursivo que retorne o fatorial de um número.

 Para resolução deste exercício foi desenvolvido um método recursivo que tem como condição de parada, o valor passado como parâmetro ser menor que 1. Neste caso (ou seja, quando N for 1 ou 0), ele retorna 1. 
 Caso a condição de parada não tenha sido alcançada, ele retorna o número vezes a chamada recursiva do próprio número menos 1.

Entradas Exemplo: 11
Saídas: 39916800


<img src=".\imagens\lista2ex1.png">

# Exercício 2: 
## Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

Para resolução deste exercício, foi realizado um método recursivo que recebe dois números como parâmetro. A condição de parada é que o segundo número seja 0. Enquanto o segundo número não for 0, a chamada recursiva testa qual o sinal de ambos os números passados pelo parâmetro e realiza uma nova chamada passando o primeiro número mais ou menos (a depender de seu sinal) a própria função passando o número e o segundo número mais ou menos 1 (a depender de seu sinal).
 
Entradas: 
-3
*
3
Saídas: -9

<img src=".\imagens\lista2ex2.png">

# Exercício 3: 
## Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A

Para solução deste exercício, foi criado um método recursivo que recebe dois números como parâmetro. A condição de parada é que o segundo número informado seja igual a 1, neste caso ele retorna o primeiro número passado. Enquanto não for igual a 1, a função retorna o primeiro número vezes a chamada recursiva da função passando o primeiro número e o segundo número - 1 como parâmetro.

Entradas: 
3
^
3
Saídas: 27


<img src=".\imagens\lista2ex3.png">

# Exercício 4: 
## Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

 Para solução deste exercício, foi necessária a criação de um método recursivo que recebe como parâmetros uma letra, um vetor de caracteres (uma string lida e convertida) e um contador de posição do vetor (passado inicialmente como 0). Então, a condição de parada é que o contador atinja o tamanho do vetor de caracteres. Enquanto não atinge, ele verifica se a posição atual do vetor estudada é igual ao caractere passado e então salva em uma string que concatena os retornos no desempilhar da chamada recursiva. Enquanto não atinge a condição de parada, a função chama ela mesma passando a letra, o vetor e o contador + 1.

Entradas: 
frase: eu gosto de AED
letra: e
Saídas: Na frase "eu gosto de aed", a letra e aparece 3 vezes


<img src=".\imagens\lista2ex4.png">

# Exercício 5: 
## Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

 Para solução deste exercício, foi desenvolvido um método recursivo que recebe um vetor de números inteiros e um contador de posição (sempre passado inicialmente como 0) como parâmetros. A condição de parada é que o contador atinja o último número do vetor. Se a condição de parada não é atingida, a função verifica se o número em questão é par, e se for, soma a uma variável auxiliar que será retorna no fim do desempilhamento. Em todo caso, a cada iteração, a função é chamada recursivamente passando o vetor e o contador mais 1 como parâmetros.

Entradas: 
tamanho do vetor: 5
os números do vetor:
1
2
3
4
5
Saídas: No vetor acima, a soma dos números pares é 6


<img src=".\imagens\lista2ex5.png">

# Exercício 6: 
## Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 

 Para solução deste exercício, foi desenvolvido um método booleano que retorna true caso uma letra passada para ele seja uma vogal. E então foi desenvolvido um método recursivo que recebe um vetor de caracteres (inicialmente uma string convertida) e um contador de posição como parâmetros. A condição de parada da recursão é que o contador atinja o último valor do vetor. Enquanto não acontece, a função verifica se a posição atual do vetor trata-se de uma vogal, caso negativo, ele concatena a letra atual em uma string que será retornada no final. Até que a condição de parada seja atingida, o método chama ele mesmo passando o vetor e o contador mais 1 como parâmetro.

Entradas: eu gosto de aed
Saídas:   gst d d


<img src=".\imagens\lista2ex6.png">