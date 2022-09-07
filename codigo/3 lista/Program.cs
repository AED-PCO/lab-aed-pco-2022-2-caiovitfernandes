class program{
    static void swap(int[] vet, int a, int b){
        int aux = vet[a];
        vet[a] = vet[b];
        vet[b] = aux;
    }

    //Exercício 1 - Busca Binária com pos
    static int buscaBinariaPos(int[] vet, int pos, int procurado){
        if(pos == vet.Length - 1){
            if(vet[pos] == procurado){
                return pos;
            }
            return -1;
        }

        else if(pos == 0){
            if(vet[pos] == procurado){
                return pos;
            }
            return -1;
        }

        if(procurado == vet[pos]){
            return pos;
        }

        if(procurado < vet[pos]){
            return buscaBinariaPos(vet, (pos / 2), procurado);
        }

        if(procurado > vet[pos]){
            return buscaBinariaPos(vet, (pos + ((vet.Length - pos) / 2)), procurado);
        }

        return -1;
    }

    //Exercício 2 - Busca Binária sem Pos
    static int buscaBinaria(int[] vet, int procurado){
        int inicio, meio, fim;
        inicio = vet[0];
        meio = vet.Length / 2;
        fim = vet.Length - 1;

        if(vet.Length == 1){
            if(procurado == vet[meio]){
                return meio;
            }
            return -1;
        }

        if(vet[meio] == procurado){
            return meio;
        }
        
        if(procurado < vet[meio]){
            int[] auxiliar = new int[(vet.Length / 2)];

            for(int i = 0; i < auxiliar.Length; i++){
                auxiliar[i] = vet[i];
            }

            return buscaBinaria(auxiliar, procurado);
        }

        int[] aux = new int[(vet.Length / 2)];

        for(int i = 0; i < aux.Length; i++){
            aux[i] = vet[i + meio];
        }

        return buscaBinaria(aux, procurado);
    }

    //Exercício 3 - Ordenação binária
    static int[] ordenacao(int[] vet){
        if(vet.Length == 1){
            return vet;
        }

        else if(vet.Length == 2){
            if(vet[0] < vet[1]){
                return vet;
            }
            swap(vet, 0, 1);
            return vet;
        }

        int[] metade1, metade2;

        if(vet.Length % 2 == 0){
            metade1 = new int[vet.Length / 2];
            metade2 = new int[vet.Length / 2];

            for(int i = 0; i < metade1.Length; i++){
                metade1[i] = vet[i];
                metade2[i] = vet[i + vet.Length / 2];
            }

            int[] ordenado1 = new int[metade1.Length];
            int[] ordenado2 = new int[metade2.Length];

            ordenado1 = ordenacao(metade1);
            ordenado2 = ordenacao(metade2);

            int[] resultado = new int[metade1.Length + metade2.Length];

            int contador1 = 0, contador2 = 0, auxiliar1 = 0, auxiliar2 = 0;
            
            for(int i = 0; i < resultado.Length; i++){
                if(ordenado1[contador1] < ordenado2[contador2] && auxiliar1 == 0){
                    resultado[i] = ordenado1[contador1];
                    if(contador1 < ordenado1.Length - 1){
                        contador1++;
                    }
                    else{
                        auxiliar1++;
                    }
                }
                else if(ordenado1[contador1] > ordenado2[contador2] && auxiliar2 == 0){
                    resultado[i] = ordenado2[contador2];
                    if(contador2 < ordenado2.Length - 1){
                        contador2++;
                    }
                    else{
                        auxiliar2++;
                    }
                }
                else if(auxiliar1 != 0){
                    resultado[i] = ordenado2[contador2];
                    contador2++;
                }
                else{
                    resultado[i] = ordenado1[contador1];
                    contador1++;
                }
            }

            return resultado;
        }
        else{
            metade1 = new int[vet.Length / 2];
            metade2 = new int[(vet.Length / 2) + 1];
        

            for(int i = 0; i < metade1.Length; i++){
                metade1[i] = vet[i];
            }
            for(int i = 0; i < metade2.Length; i++){
                metade2[i] = vet[i + vet.Length / 2];
            }

            int[] ordenado1 = new int[metade1.Length];
            int[] ordenado2 = new int[metade2.Length];

            ordenado1 = ordenacao(metade1);
            ordenado2 = ordenacao(metade2);

            int[] resultado = new int[metade1.Length + metade2.Length];

            int contador1 = 0, contador2 = 0, auxiliar1 = 0, auxiliar2 = 0;
            
            for(int i = 0; i < resultado.Length; i++){
                if(ordenado1[contador1] < ordenado2[contador2] && auxiliar1 == 0){
                    resultado[i] = ordenado1[contador1];
                    if(contador1 < ordenado1.Length - 1){
                        contador1++;
                    }
                    else{
                        auxiliar1++;
                    }
                }
                else if(ordenado1[contador1] > ordenado2[contador2] && auxiliar2 == 0){
                    resultado[i] = ordenado2[contador2];
                    if(contador2 < ordenado2.Length - 1){
                        contador2++;
                    }
                    else{
                        auxiliar2++;
                    }
                }
                else if(auxiliar1 != 0){
                    resultado[i] = ordenado2[contador2];
                    contador2++;
                }
                else{
                    resultado[i] = ordenado1[contador1];
                    contador1++;
                }
            }
        
            return resultado;
        }
    }

    //Exercício 4 - Ordenação com Pos
    static int[] ordenacaoPos(int[] vet, int pos){
        if(vet.Length == 1){
            return vet;
        }

        else if(vet.Length == 2){
            if(vet[0] < vet[pos]){
                return vet;
            }
            swap(vet, 0, 1);
            return vet;
        }

        int[] metade1, metade2;

        if(vet.Length % 2 == 0){
            metade1 = new int[vet.Length / 2];
            metade2 = new int[vet.Length / 2];

            for(int i = 0; i < metade1.Length; i++){
                metade1[i] = vet[i];
                metade2[i] = vet[i + vet.Length / 2];
            }

            int[] ordenado1 = new int[metade1.Length];
            int[] ordenado2 = new int[metade2.Length];

            ordenado1 = ordenacao(metade1);
            ordenado2 = ordenacao(metade2);

            int[] resultado = new int[metade1.Length + metade2.Length];

            int contador1 = 0, contador2 = 0, auxiliar1 = 0, auxiliar2 = 0;
            
            for(int i = 0; i < resultado.Length; i++){
                if(ordenado1[contador1] < ordenado2[contador2] && auxiliar1 == 0){
                    resultado[i] = ordenado1[contador1];
                    if(contador1 < ordenado1.Length - 1){
                        contador1++;
                    }
                    else{
                        auxiliar1++;
                    }
                }
                else if(ordenado1[contador1] > ordenado2[contador2] && auxiliar2 == 0){
                    resultado[i] = ordenado2[contador2];
                    if(contador2 < ordenado2.Length - 1){
                        contador2++;
                    }
                    else{
                        auxiliar2++;
                    }
                }
                else if(auxiliar1 != 0){
                    resultado[i] = ordenado2[contador2];
                    contador2++;
                }
                else{
                    resultado[i] = ordenado1[contador1];
                    contador1++;
                }
            }

            return resultado;
        }
        else{
            metade1 = new int[vet.Length / 2];
            metade2 = new int[(vet.Length / 2) + 1];
        

            for(int i = 0; i < metade1.Length; i++){
                metade1[i] = vet[i];
            }
            for(int i = 0; i < metade2.Length; i++){
                metade2[i] = vet[i + vet.Length / 2];
            }

            int[] ordenado1 = new int[metade1.Length];
            int[] ordenado2 = new int[metade2.Length];

            ordenado1 = ordenacao(metade1);
            ordenado2 = ordenacao(metade2);

            int[] resultado = new int[metade1.Length + metade2.Length];

            int contador1 = 0, contador2 = 0, auxiliar1 = 0, auxiliar2 = 0;
            
            for(int i = 0; i < resultado.Length; i++){
                if(ordenado1[contador1] < ordenado2[contador2] && auxiliar1 == 0){
                    resultado[i] = ordenado1[contador1];
                    if(contador1 < ordenado1.Length - 1){
                        contador1++;
                    }
                    else{
                        auxiliar1++;
                    }
                }
                else if(ordenado1[contador1] > ordenado2[contador2] && auxiliar2 == 0){
                    resultado[i] = ordenado2[contador2];
                    if(contador2 < ordenado2.Length - 1){
                        contador2++;
                    }
                    else{
                        auxiliar2++;
                    }
                }
                else if(auxiliar1 != 0){
                    resultado[i] = ordenado2[contador2];
                    contador2++;
                }
                else{
                    resultado[i] = ordenado1[contador1];
                    contador1++;
                }
            }
        
            return resultado;
        }
    }

    static void Main(string[] args){
        int programa = 1;
        do{
            Console.Write("Escolha qual programa rodar:\n1 - Busca binária\n2 - Busca Binária otimizada (Sem Pos)\n3 - Ordenação binária otimizada (Sem Pos)\n4 - Ordenação binária com pos\n0 - Sair do programa\n");
            programa = int.Parse(Console.ReadLine());

            if(programa == 1){
                Console.Write("Escolha um tamanho para o vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine($"Agora escreva os {tamanho} números do vetor:");

                int[] vetor = new int[tamanho];

                for(int i = 0; i < tamanho; i++){
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(vetor);

                Console.Write("Agora escreva qual número quer buscar no array: ");
                int busca = int.Parse(Console.ReadLine());

                int resultado = buscaBinariaPos(vetor, (tamanho / 2), busca);

                Console.Write("No vetor ordenado: ");
                for (int i = 0; i < vetor.Length; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                if(resultado == -1){
                    Console.WriteLine($"\n{busca} não está no vetor");
                }
                else{
                    Console.WriteLine($"\n{busca} está na posição {resultado} do vetor.");
                }

                Console.Write("Pressione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

            if(programa == 2){
                Console.Write("Escolha um tamanho para o vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine($"Agora escreva os {tamanho} números do vetor:");

                int[] vetor = new int[tamanho];

                for(int i = 0; i < tamanho; i++){
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(vetor);

                Console.Write("Agora escreva qual número quer buscar no array: ");
                int busca = int.Parse(Console.ReadLine());

                int resultado = buscaBinaria(vetor, busca);

                Console.Write("No vetor ordenado: ");
                for (int i = 0; i < vetor.Length; i++){
                    Console.Write($"{vetor[i]}  ");
                }

                if(resultado == -1){
                    Console.WriteLine($"\n{busca} não está no vetor");
                }
                else{
                    Console.WriteLine($"\n{busca} está no vetor.");
                }

                Console.Write("Pressione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

            if(programa == 3){
                Console.Write("Escolha um tamanho para o vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine($"Agora escreva os {tamanho} números do vetor:");

                int[] vetor = new int[tamanho];

                for(int i = 0; i < tamanho; i++){
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Vetor ordenado:");
                
                int[] resultado = new int[tamanho];
                resultado = ordenacao(vetor);

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{resultado[i]}  ");
                }

                Console.Write("\nPressione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

            if(programa == 4){
                Console.Write("Escolha um tamanho para o vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.WriteLine($"Agora escreva os {tamanho} números do vetor:");

                int[] vetor = new int[tamanho];

                for(int i = 0; i < tamanho; i++){
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Vetor ordenado:");
                
                int[] resultado = new int[tamanho];
                resultado = ordenacaoPos(vetor, (vetor.Length - 1));

                for(int i = 0; i < tamanho; i++){
                    Console.Write($"{resultado[i]}  ");
                }

                Console.Write("\nPressione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

        }while(programa > 0 && programa < 5);
    }
}