#Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em um único arquivo .cs. A execussão dos programas é feita de maneira sequencial. Ou seja, são executados um atrás do outro. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

#Exercício 1: 
##Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
##Número = 3025 
##Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . A soma de 30 com 25 é igual a 55 O Quadrado de 55 é igual a 3025.
 
##Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

Para resolução, o programa parte do preceito de que dividindo um número de 4 algarismos por 100, podemos pegar os dois primeiros algarismos, e fazendo a operação de mod (%), podemos pegar os dois algarismos restantes. Depois o programa soma esses dois resultados, eleva ao quadrado e verifica se é igual ao número de entrada. 
Entradas: Com um for, o programa fornece como entrada para a função, todos os números de 1000 a 9999.
Saídas: 
2025
3025
9801

#Exercício 2:
##