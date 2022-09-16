# Sobre a lista 5:
A lista 5 não trata-se de um programa que precisou ser desenvolvido. A lista tratou-se de, a partir de códigos disponibilizados pelo professor, fazer uma análise detalhada da complexidade dos mesmos, analisando-se quais eram as operações mais relevantes, desenvolvendo a função que descreva o custo das operações e calculando por fim a ordem de complexidade de cada código. A seguir encontra-se a resolução dos exercícios.

# Exercícios:
## Exercício 1:
~~~C#
public int alg1(int n){
    int res = 1;
    for(int i=n; i>1; i--){
        res = res*i;
    }
    return res;
}
~~~
**Funções de custo das operações (considerando os piores casos; considerando apenas operações com custos variáveis - dentro de laços de repetição ou que a quantidade de execuções dependa de outra variável; desconsiderando as operações de atribuição, comparação, incremento/decremento dos laços for):**
* Atribuições: f(n) = n - 1
* Multiplicações: f(n) = n - 1

**Operação mais relevante:**
As operações mais relevantes são Atribuição e Multiplicações.

**Variações de casos (por ordem de complexidade):**
* Pior Caso: O(n)
* Melhor Caso: O(n)
* Caso Médio: (O(n) + O(n)) / 2 = O(n)

## Exercício 2:
~~~C#
public int alg1(int n){
    int res = 1;
    for(int i=n; i>1; i--){
        res = res*i;
    }
    return res;
}
~~~
**Funções de custo das operações (considerando os piores casos):**
* Atribuições:
* Multiplicações:
* Comparações:
* Decrementos:
* Retornos:

**Operação mais relevante:**

**Variações de casos (por ordem de complexidade):**
* Pior Caso:
* Melhor Caso:
* Caso Médio:

## Exercício 3:
~~~C#
public int alg1(int n){
    int res = 1;
    for(int i=n; i>1; i--){
        res = res*i;
    }
    return res;
}
~~~
**Funções de custo das operações (considerando os piores casos):**
* Atribuições:
* Multiplicações:
* Comparações:
* Decrementos:
* Retornos:

**Operação mais relevante:**

**Variações de casos (por ordem de complexidade):**
* Pior Caso:
* Melhor Caso:
* Caso Médio:

## Exercício 4:
~~~C#
public int alg1(int n){
    int res = 1;
    for(int i=n; i>1; i--){
        res = res*i;
    }
    return res;
}
~~~
**Funções de custo das operações (considerando os piores casos):**
* Atribuições:
* Multiplicações:
* Comparações:
* Decrementos:
* Retornos:

**Operação mais relevante:**

**Variações de casos (por ordem de complexidade):**
* Pior Caso:
* Melhor Caso:
* Caso Médio: