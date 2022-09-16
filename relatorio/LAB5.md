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
* Melhor Caso: Ω(n)
* Caso Médio: (n + n) / 2 = n = Θ(n)

## Exercício 2:
~~~C#
public int alg2(int[] arr, int x){
    for(int i=0; i<arr.length; i++){
        if(arr[i] == x) return x;
    }
    return -1;
}
~~~
**Funções de custo das operações (considerando os piores casos; considerando apenas operações com custos variáveis - dentro de laços de repetição ou que a quantidade de execuções dependa de outra variável; desconsiderando as operações de atribuição, comparação, incremento/decremento dos laços for):**
* Comparações: f(n) = n
* Retornos: 1

**Operação mais relevante:**
A operação mais relevante é a Comparação.

**Variações de casos (por ordem de complexidade):**
* Pior Caso: O(n)
* Melhor Caso: Ω(1)
* Caso Médio: (n + 1) / 2 = Θ(n)

## Exercício 3:
~~~C#
double[] alg3(double []arr1){  
   double[] res;
   for(int pos = 0; pos<arr1.length; pos++){
        for(int j = 0; j<arr1.length; j++){
            if(j!=pos)
                res[pos] += arr1[pos]/arr1[j]; 
       }
   }
   return res;
}
~~~
**Funções de custo das operações (considerando os piores casos; considerando apenas operações com custos variáveis - dentro de laços de repetição ou que a quantidade de execuções dependa de outra variável; desconsiderando as operações de atribuição, comparação, incremento/decremento dos laços for):**
* Atribuições: f(n) = n * (n - 1) = n<sup>2</sup> - n
* Comparações: f(n) = n * n = n<sup>2</sup>
* Soma: f(n) = n * (n - 1) = n<sup>2</sup> - n
* Divisão: f(n) = n * (n - 1) = n<sup>2</sup> - n

**Operação mais relevante:**
As operações mais relevantes são Atribuição, Comparação, Soma e Divisão.

**Variações de casos (por ordem de complexidade):**
* Pior Caso: O(n<sup>2</sup>)
* Melhor Caso: Ω(n<sup>2</sup>)
* Caso Médio: (n<sup>2</sup> + n<sup>2</sup>) / 2 = Θ(n<sup>2</sup>)

## Exercício 4:
~~~C#
public double[] alg4(int[] dados){        
    double[] vet = new double[dados.length];
    for(int i=0; i<dados.length; i++){
        double soma=0.0;
        for(int j=0; j<=i; j++)
            soma += dados[j];
            vet[i] = soma/(i+1);
        }
    return vet;
}
~~~
**Funções de custo das operações (considerando os piores casos; considerando apenas operações com custos variáveis - dentro de laços de repetição ou que a quantidade de execuções dependa de outra variável; desconsiderando as operações de atribuição, comparação, incremento/decremento dos laços for):**
* Atribuições: f(n) = n + 2 (n<sup>2</sup> + n) / 2 = n<sup>2</sup> + 2n
* Divisões: f(n) = (n<sup>2</sup> + 2) / 2
* Soma: 2 (n<sup>2</sup> + n) / 2 = n<sup>2</sup> + n 

**Operação mais relevante:**
As operações mais relevantes são Atribuição, Divisão e Soma.

**Variações de casos (por ordem de complexidade):**
* Pior Caso: O(n<sup>2</sup>)
* Melhor Caso: Ω(n<sup>2</sup>)
* Caso Médio: (n<sup>2</sup> + n<sup>2</sup>) / 2 = Θn<sup>2</sup>