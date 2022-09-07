# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita a partir da seleção feita pelo usuário em um menu implementado assim que o programa é aberto. Na pasta do projeto, há também um arquivo chamado Programa.bat. Este arquivo executa o programa no console do computador. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Faça um programa que realize a busca de um número inteiro em um vetor de maneira binária

Para resolução deste exercício, foi desenvolvido um método recursivo que recebe como parâmetros um vetor de inteiros ordenado, uma posição (que sempre deve iniciar no meio do vetor) e o número que será procurado. O método possui duas condições de parada, uma caso pos atinja a primeira posição do vetor e outra caso pos atinja a última posição do vetor. Enquanto a condição não é satisfeita, o programa sempre verifica se vetor na posição pos é igual ao número procurado. Caso seja, ele retorna pos. Caso não seja, ele verifica se o número procurado é maior ou menor que vetor na posição pos. Caso seja maior, ele chama a própria função, passando pos como o meio da metade de cima do vetor. Caso seja menor, ele chama a própria função, passando o pos como o meio da metade de baixo do vetor. Caso no fim, ele não encontre o valor procurado, ele retorna -1. No main, caso o retorno da chamada seja diferente de -1, o programa printa que encontrou o número na posição pos do vetor. Caso seja -1, ele printa que não encontrou o número procurado.

Entradas Exemplo: 
Tamanho do vetor: 4
Números do vetor: 1, 2, 3, 4
Número procurado: 2
Saídas: 2 está na posição 1 do vetor.


<img src=".\imagens\lista3ex1.png">

# Exercício 2: 
## Faça um programa que realize a busca de um número inteiro em vetor de maneira binária e sem passar a posição como parâmetro

Para resolução deste exercício, foi desenvolvido um método recursivo que recebe apenas o vetor desordenado e o número procurado como parâmetros. A condição de parada da recursividade é o tamanho do vetor ser 1. Caso isso aconteça, o programa verifica se o único número no vetor é o número procurado. Caso seja, retorna a posição do número. Caso não seja, retorna -1. Enquanto essa condição não é satisfeita, o método atribui a posição do meio do vetor a uma variável chamada meio. Então verifica se o número do meio do vetor é o número procurado. Caso seja, ele retorna o valor de meio. Caso o número procurado seja maior, a função chama ela mesma passando a metade de cima do vetor e o número procurado como parâmetros. Caso seja menor, passa a metade de baixo do vetor e o número procurado.
 
Entradas Exemplo: 
Tamanho do vetor: 4
Números do vetor: 1, 2, 3, 4
Número procurado: 2
Saídas: 2 está no vetor

<img src=".\imagens\lista3ex2.png">

# Exercício 3: 
## Faça um programa que realize a ordenação binária de um vetor desordenado

Para solução deste exercício, foi criado um método recursivo que recebe apenas o vetor desordenado como parâmetro. Existem duas condições de parada da recursividade. Uma caso o vetor tenha tamanho 1, outra caso o vetor tenha tamanho 2. No caso de ter tamanho 1, ele retorna o vetor. Caso tenha tamanho 2, ele verifica se o número da posição 1 é menor que o número da posição 0. Caso seja, ele efetua a troca de lugar desses dois números e então retorna o vetor. Enquanto essas condições não são satisfeitas, a função chama ela mesma para que todo o vetor seja quebrado em pares ou em um número único e ordene essas partes. E então, depois de ordenar os pares, a função compara par a par ordenando os subvetores até que se tenha um vetor completo ordenado.

Entradas Exemplo: 
Tamanho do vetor: 4
Números do vetor: 2, 3, 1, 4
Saídas:
Vetor ordenado: 1  2  3  4


<img src=".\imagens\lista3ex3.png">

# Exercício 4: 
## Faça um programa que realize a ordenação binária de um vetor desordenado, recebendo uma posição como parâmetro

Para solução deste exercício, foi criado um método recursivo que recebe o vetor desordenado e a última posição do vetor como parâmetro. Existem duas condições de parada da recursividade. Uma caso o vetor tenha tamanho 1, outra caso o vetor tenha tamanho 2. No caso de ter tamanho 1, ele retorna o vetor. Caso tenha tamanho 2, ele verifica se o número da posição passada como parâmetro é menor que o número da posição 0. Caso seja, ele efetua a troca de lugar desses dois números e então retorna o vetor. Enquanto essas condições não são satisfeitas, a função chama ela mesma para que todo o vetor seja quebrado em pares ou em um número único e ordene essas partes. E então, depois de ordenar os pares, a função compara par a par ordenando os subvetores até que se tenha um vetor completo ordenado.

Entradas Exemplo: 
Tamanho do vetor: 5
Números do vetor: 7, 4, 3, 1, 2
Saídas:
Vetor ordenado: 1  2  3  4  7


<img src=".\imagens\lista3ex4.png">
