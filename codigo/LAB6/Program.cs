class program{
    static void vetorAleatorio(int[] vetor){
        Random numero = new Random();
        for(int i = 0; i < vetor.Length; i++){
            vetor[i] = numero.Next(10000);
        }
    }

    static void swap(int[]vetor, int posA, int posB){
        int aux = vetor[posA];
        vetor[posA] = vetor[posB];
        vetor[posB] = aux;
    }

    static void insert(int[] vetor, int posInicio, int posFim){
        int valorInserido = vetor[posFim];

        for(int i = posFim; i > posInicio; i--){
            vetor[i] = vetor[i - 1];
        }

        vetor[posInicio] = valorInserido;
    }

    static void BubbleSort(int[] vetor){
        for(int i = vetor.Length - 1; i > 1; i--){
            for(int j = 0; j < i; j++){
                if(vetor[j] > vetor[j + 1]){
                    swap(vetor, j, j + 1);
                }
            }
        }
    }

    static void SelectionSort(int[] vetor){
        for(int i = 0; i < vetor.Length - 2; i++){
            int menor = i;
            for(int j = i + 1; j < vetor.Length - 1; j++){
                if(vetor[j] < vetor[menor]){
                    menor = j;
                }
            }
            swap(vetor, i, menor);
        }
    }

    static void InsertionSort(int[] vetor){
        for(int i = 1; i < vetor.Length; i++){
            int aux = 0, troca = 0;
            int j = i - 1;

            while(aux == 0){
                if(j == 0){
                    if(vetor[j] > vetor[i]){
                        troca++;
                    }
                    aux = 1;
                }
                else if(vetor[j] < vetor[i]){
                    aux = 1;
                }
                else{
                    j--;
                    troca++;
                }
            }

            insert(vetor, i - troca, i);
        }
    }

    static void Main(string[] args){
        int programa = 1;
        while(programa > 0 && programa < 4){
            Console.Clear();
            Console.Write("Escolha qual algoritmo de ordenação será usado:\n1 - Bubble Sort\n2 - Selection Sort\n3 - Insertion Sort\n0 - Sair do Programa\n\nResposta: ");
            programa = int.Parse(Console.ReadLine());
            Console.Clear();

            if(programa <= 0 || programa >= 4){
                break;
            }

            Console.Write("Agora informe o tamanho do vetor a ser ordenado(observação: o vetor será preenchido com números aleatórios utilizando a classe Random): ");
            int tamanho = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("O vetor aleatório gerado é:");
            int[] vetor = new int[tamanho];
            vetorAleatorio(vetor);
            for(int i = 0; i < tamanho; i++){
                Console.Write($"{vetor[i]}  ");
            }
            
            Console.WriteLine("\nEste mesmo vetor ordenado pelo método escolhido fica:\n");

            if(programa == 1){
                BubbleSort(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

            if(programa == 2){
                SelectionSort(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

            if(programa == 3){
                InsertionSort(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}