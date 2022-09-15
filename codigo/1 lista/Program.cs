class program{        
    static void Main(string[] args){   
        int menu = 1;

        while(menu < 7 && menu > 0){
            Console.Write("Selecione o exercício que deseja rodar:\n1 - Exercício 1\n2 - Exercício 2\n3 - Exercício 3\n4 - Exercício 4\n5 - Exercício 5\n6 - Exercício 6\n7 - Sair do programa\n\nEscolha: ");

            menu = int.Parse(Console.ReadLine());

            if(menu == 1){
                // Exercício 1 
                Console.Write("-----Exercício 1-----" + "\n" + "-> Respostas:" + "\n");
                for (int i = 1000; i <= 9999; i++){

                    int primeira_parte = i/100;
                    int segunda_parte = i%100;
                    int soma = primeira_parte + segunda_parte;

                    if ((soma * soma) == i)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 2){
                //Exercício 2, 1a parte
                Console.Write("-----Exercício 2-----" + "\n" + "Questão A:" + "\n" + "Digite um número para saber se é primo: ");

                Boolean ePrimo(int num){
                    for(int i2 = 2; i2 < num; i2++){
                        if(num % i2 == 0){
                            return false;
                        }
                    }
                    return true;
                }

                int numero = int.Parse(Console.ReadLine());

                if(ePrimo(numero)){
                    Console.WriteLine(numero + " é primo.");
                }
                else{
                    Console.WriteLine(numero + " não é primo.");
                }

                Console.Write("\n" + "Questão B:" + "\n");
            

                //Exercício 2, 2a parte
                Console.WriteLine("Os números perfeitos de 1 a 1000 são:");
                int soma_dos_divisores = 0;
                int contador = 0;

                for (int i = 1; i <= 1000; i++){
                    for(int j = 1; j < i; j++){
                        if((i % j) == 0){
                            soma_dos_divisores += j;
                            contador++;
                        }
                    }

                    if(soma_dos_divisores == i){
                        Console.WriteLine(i);
                    }
                    
                    soma_dos_divisores = 0;
                }
                Console.WriteLine("Contador de somas e atribuições:" + contador);
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 3){
                //Exercício 3
                Console.Write("-----Exercício 3-----\n");

                int[] a = new int[5];
                int [] b = new int[5];
                Console.WriteLine("Digite 10 valores. 5 preencherão o primeiro vetor e 5 o segundo vetor:");
                for (int contador = 0; contador < 5; contador++){
                    a[contador] = int.Parse(Console.ReadLine());
                }
                for (int contador = 0; contador < 5; contador++){
                    b[contador] = int.Parse(Console.ReadLine());
                }

                int[] c = new int[5];
                int contC = 0;
                int[] d = new int[5];
                int contD = 0;
                int aux = 0;

                for(int i = 0; i < a.Length; i++){
                    aux = contC;
                    for(int j = 0; j < b.Length; j++){
                        if(a[i] == b[j]){
                            c[contC] = a[i];
                            contC++;
                        }
                    }
                    if(aux == contC){
                        d[contD] = a[i];
                        contD++;
                    }
                }

                Console.Write($"Sejam os vetores \na = {a[0]}, {a[1]}, {a[2]}, {a[3]}, {a[4]} e \nb = {b[0]}, {b[1]}, {b[2]}, {b[3]}, {b[4]}. \nOs números em comum são: {c[0]}, {c[1]}, {c[2]}, {c[3]}, {c[4]}\ne os números de a que não estão em b: {d[0]}, {d[1]}, {d[2]}, {d[3]}, {d[4]}\n");
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 4){
                //Exercício 4
                Console.Write("-----Exercício 4-----\nSeja uma matriz de 5 linhas (numeradas de 1 a 5) por 3 colunas (numeradas de 1 a 3), digite os valores das células dessa matriz:\n");

                int[,] matriz = new int[5, 3];

                for(int i = 0; i < 5; i++){
                    for (int j = 0; j < 3; j++){
                        Console.Write($"Célula {i + 1}{j + 1}: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int somaLinha(int[,] matriz, int linha, int numeroDeColunas){
                    int resultado = 0;
                    for(int i = 0; i < numeroDeColunas; i++){
                        resultado += matriz[linha, i];
                    }

                    return resultado;
                }

                int somaColuna (int[,] matriz, int numeroDeLinhas, int coluna){
                    int resultado = 0;
                    for(int i = 0; i < numeroDeLinhas; i++){
                        resultado += matriz[i, coluna];
                    }

                    return resultado;
                }

                Console.Write($"\nMatriz:\n{matriz[0, 0]} {matriz[0, 1]} {matriz[0, 2]} \n{matriz[1, 0]} {matriz[1, 1]} {matriz[1, 2]} \n{matriz[2, 0]} {matriz[2, 1]} {matriz[2, 2]} \n{matriz[3, 0]} {matriz[3, 1]} {matriz[3, 2]} \n{matriz[4, 0]} {matriz[4, 1]} {matriz[4, 2]}\n\n");

                for(int i = 0; i < 5; i ++){
                    Console.WriteLine($"Soma da linha {i + 1}: {somaLinha(matriz, i, 3)}");
                }
                for(int i = 0; i < 3; i ++){
                    Console.WriteLine($"Soma da Coluna {i + 1}: {somaColuna(matriz, 5, i)}");
                }
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 5){
                //Exercício 5
                Console.Write("-----Exercício 5-----\nDigite um número para calcular seu fatorial: ");
                int num = int.Parse(Console.ReadLine());

                static double fatorial(int number){
                    double respost = number;
                    if(number < 1){
                        return 1;
                    }
                    else{
                        respost *= fatorial(number - 1);
                    }
                    return respost;
                }

                Console.WriteLine($"O fatorial de {num} é {fatorial(num)}");
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 6){
                //Exercício 6
                Console.Write("-----Exercício 6-----\nDigite dois números, sendo que o primeiro será elevado ao segundo:\n");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("^");
                int y = int.Parse(Console.ReadLine());

                static int eleva(ref int x, ref int y){
                    int aux = x;
                    for(int i = 1; i < y; i++){
                        x *= aux;
                    }
                    return x;
                }

                Console.WriteLine($"{x} ^ {y} = {eleva(ref x, ref y)}");
                Console.WriteLine("Enter para continuar.");
                Console.ReadLine();
                Console.Clear();
            }
            else{
                Console.WriteLine("Fim do programa!");
            }
        }
    }
} 