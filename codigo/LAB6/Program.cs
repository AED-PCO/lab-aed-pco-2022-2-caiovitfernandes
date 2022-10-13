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

    static void insertHop(int[] vetor, int trocas, int hop, int pos){
        int aux = vetor[pos];
        int aux2 = trocas;
        for(int i = pos; trocas > 0; i -= hop){
            vetor[i] = vetor[i - hop];
            trocas--;
        }
        vetor[pos - (aux2 * hop)] = aux;
    }

    static void BubbleSort(int[] vetor){
        int trocas = 0, comparacoes = 0;
        for(int i = vetor.Length - 1; i > 1; i--){
            for(int j = 0; j < i; j++){
                if(vetor[j] > vetor[j + 1]){
                    swap(vetor, j, j + 1);
                    trocas++;
                }
                comparacoes++;
            }
        }
        Console.Write($"Comparações = {comparacoes}\nTrocas = {trocas}\n\n");
    }

    static void SelectionSort(int[] vetor){
        int trocas = 0, comparacoes = 0;
        for(int i = 0; i < vetor.Length - 2; i++){
            int menor = i;
            for(int j = i + 1; j < vetor.Length - 1; j++){
                if(vetor[j] < vetor[menor]){
                    menor = j;
                }
                comparacoes++;
            }
            swap(vetor, i, menor);
            trocas++;
        }
        Console.Write($"Comparações = {comparacoes}\nTrocas = {trocas}\n\n");
    }

    static void InsertionSort(int[] vetor){
        int trocas = 0, comparacoes = 0;
        for(int i = 1; i < vetor.Length; i++){
            int aux = 0, troca = 0;
            int j = i - 1;

            while(aux == 0){
                if(j == 0){
                    if(vetor[j] > vetor[i]){
                        troca++;
                        trocas += troca;
                    }
                    aux = 1;
                    comparacoes++;
                }
                else if(vetor[j] < vetor[i]){
                    aux = 1;
                    comparacoes+= 2;
                }
                else{
                    j--;
                    troca++;
                    trocas+= troca;
                    comparacoes+= 2;
                }
            }

            insert(vetor, i - troca, i);
        }
        Console.Write($"Comparações = {comparacoes}\nTrocas = {trocas}\n\n");
    }

    //Continuação da lista 6: ordenação com week, contagem e merge sort

    static int[] ContSort(int[] vetor){
        int comparacoes = 0;
        int trocas = 0;
        int[] tabela = new int[10000];
        int[] pos = new int[10000];
        int[] resultado = new int[vetor.Length];

        pos[0] = 0;
        for(int i = 0; i < vetor.Length; i++){
            tabela[vetor[i]]++;
        }
        for(int j = 1; j < pos.Length; j++){
            pos[j] = pos[j - 1] + tabela[j - 1];
        }

        for(int k = 0; k < vetor.Length; k++){
            resultado[pos[vetor[k]]] = vetor[k];
            pos[vetor[k]]++;
        }

        return resultado;
        Console.Write($"Comparações = {comparacoes}\nTrocas = {trocas}\n\n");
    }

    static void shellSort(int[] vetor){
        int comparacoes = 0;
        int trocas = 0;
        int hop = 4;


        while(hop > 0){
            comparacoes++;
            for(int i = hop; i < vetor.Length; i++){
                int j = i - hop;
                int aux = 0;
                int troca = 0;

                while(aux == 0){
                    comparacoes++;
                    if(j < 0){
                        comparacoes++;
                        aux = 1;
                    }
                    else if(j == 0){
                        comparacoes++;
                        if(vetor[j] > vetor[i]){
                            comparacoes++;
                            troca++;
                            trocas++;
                        }
                        aux = 1;
                    }
                    else if(vetor[j] < vetor[i]){
                        aux = 1;
                        comparacoes++;
                    }
                    else{
                        troca++;
                        trocas++;
                        j -= hop;
                    }
                }
                if(troca != 0){
                    comparacoes++;
                    insertHop(vetor, troca, hop, i);
                }
            }
            hop /= 2;
        }
        Console.Write($"Comparações = {comparacoes}\nTrocas = {trocas}\n\n");
    }

    static void quickSort(int[] vetor, int inicio, int fim){
        if(inicio < fim){
            int pivo, part;
            pivo = vetor[fim];
            part = inicio - 1;
            
            for(int i = inicio; i < fim; i++){
                if(vetor[i] <= pivo){
                    part++;
                    swap(vetor, i, part);
                }
            }
            part++;
            swap(vetor, fim, part);

            quickSort(vetor, inicio, part -1);
            quickSort(vetor, part + 1, fim);
        }
    }

    static void Main(string[] args){
        int programa = 1;
        while(programa > 0 && programa < 7){
            Console.Clear();
            Console.Write("Escolha qual algoritmo de ordenação será usado:\n1 - Bubble Sort\n2 - Selection Sort\n3 - Insertion Sort\n4 - Ordenação por contagem\n5 - Shell Sort\n6 - Quick Sort\n0 - Sair do Programa\n\nResposta: ");
            programa = int.Parse(Console.ReadLine());
            Console.Clear();

            if(programa <= 0 || programa >= 7){
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

            if(programa == 4){
                int[] resultado = ContSort(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{resultado[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

            if(programa == 5){
                shellSort(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

            if(programa == 6){
                quickSort(vetor, 0, vetor.Length - 1);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                Console.Write("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}