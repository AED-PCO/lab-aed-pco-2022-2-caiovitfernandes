namespace LAB8{
    class fila{
        public static void shift(int[] vetor, int inicio, int fim, string sentido){
            if(sentido == "esquerda"){
                for(int i = inicio; i <= fim; i++){
                    vetor[i - 1] = vetor[i];
                }
            }
            else if(sentido == "direita"){
                for(int i = fim; i >= inicio; i--){
                    vetor[i + 1] = vetor[i];
                }
            }
        }
        public static void inserir(int[] vetor, int valor, ref int referencia){
            vetor[referencia] = valor;
            referencia++;
        }

        public static int remover(int[] vetor, ref int referencia){
            int retorno = vetor[0];
            shift(vetor, 1, (referencia - 1), "esquerda");
            referencia--;
            return retorno;
        }

        public static void mostrar(int[] vetor, ref int referencia){
            int auxiliar;
            for(int i = referencia; i > 0; i--){
                auxiliar = remover(vetor, ref referencia);
                Console.Write($"{auxiliar}\t");
                inserir(vetor, auxiliar, ref referencia);
            }
        }
    }
    
   class pilha{
        public static void inserir(int[] vetor, int valor, ref int referencia){
            vetor[referencia] = valor;
            referencia++;
            Console.WriteLine("Valor inserido!");
        }

        public static int remover(int[] vetor, ref int referencia){
            int retorno = vetor[referencia - 1];
            referencia --;
            return retorno;
        }

        public static void mostrar(int[] vetor, ref int referencia){
            int[] auxiliar = vetor;
            int refAux = referencia;
            for(int i = 0; i < refAux; i++){
                Console.Write($"{remover(auxiliar, ref referencia)}\t");
            }
            referencia =  refAux;
            Console.WriteLine();
        }
    }

    class lista{
        public static void inserir(int[] vetor, int valor, ref int referencia, int pos){
            if(pos >= referencia){
                vetor[referencia] = valor;
                referencia++;
                Console.WriteLine("Valor inserido!");
            }
            else if(pos < 0){
                Console.WriteLine("Posição inválida!");
            }
            else{
                fila.shift(vetor, pos, referencia - 1, "direita");
                vetor[pos] = valor;
                referencia++;
                Console.WriteLine("Valor inserido!");
            }
        }

        public static int remover(int[] vetor, ref int referencia, int pos){
            if(pos >= referencia){
                Console.WriteLine("Posição inválida!");
                return -999999;
            }
            else if(pos < 0){
                Console.WriteLine("Posição inválida!");
                return -999999;
            }
            else{
                int retorno = vetor[pos];
                fila.shift(vetor, pos + 1, referencia - 1, "esquerda");
                referencia --;
                return retorno;
            }   
        }

        public static void mostrar(int[] vetor, ref int referencia){
            for(int i = 0; i < referencia; i++){
                Console.Write($"{vetor[i]}\t");
            }
        }
    }

    class program{
        static void Main(string[] args){
            Console.Write("Escolha o tamanho do vetor que recebera a estrutura: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];
            Console.WriteLine("Vetor criado com sucesso!");
            Console.ReadLine();
            Console.Clear();

            int resposta = 1;
            while(resposta >= 1 && resposta <= 3){
                Console.Write("Agora escolha qual estrutura deseja usar:\n1 - Pilha\n2 - Lista\n3 - Fila\n0 - Sair\nResposta: ");
                resposta = int.Parse(Console.ReadLine());
                Console.Clear();

                if(resposta == 1){
                    int referencia = 0;
                    int escolha = 1;
                    while(escolha >= 1 && escolha <= 3){
                        Console.Write("Escolha o que deseja fazer: \n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Voltar ao menu\nResposta: ");
                        escolha = int.Parse(Console.ReadLine());
                        Console.Clear();
                        
                        if(escolha == 1){
                            int valor;
                            Console.Write("Informe o valor a ser inserido: ");
                            valor = int.Parse(Console.ReadLine());

                            pilha.inserir(vetor, valor, ref referencia);
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 2){
                            Console.WriteLine($"Valor removido: {pilha.remover(vetor, ref referencia)}");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 3){
                            pilha.mostrar(vetor, ref referencia);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        
                        else{
                            Console.Clear();
                            break;
                        }
                    }
                    Console.Clear();
                }

                else if(resposta == 2){
                    int referencia = 0;
                    int escolha = 1;
                    while(escolha >= 1 && escolha <= 3){
                        Console.Write("Escolha o que deseja fazer: \n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Voltar ao menu\nResposta: ");
                        escolha = int.Parse(Console.ReadLine());
                        Console.Clear();      
                                                
                        if(escolha == 1){
                            int valor;
                            int pos;
                            Console.Write("Informe o valor a ser inserido: ");
                            valor = int.Parse(Console.ReadLine());
                            Console.Write("Agora informe a posição da lista: ");
                            pos = int.Parse(Console.ReadLine());

                            lista.inserir(vetor, valor, ref referencia, pos);
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 2){
                            int pos;
                            Console.Write("Escolha a posição da lista a ser removida: ");
                            pos = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Valor removido: {lista.remover(vetor, ref referencia, pos)}");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 3){
                            lista.mostrar(vetor, ref referencia);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        
                        else{
                            Console.Clear();
                            break;
                        }            
                    }
                    Console.Clear();
                }

                else if(resposta == 3){
                    int referencia = 0;
                    int escolha = 1;
                    while(escolha >= 1 && escolha <= 3){
                        Console.Write("Escolha o que deseja fazer: \n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Voltar ao menu\nResposta: ");
                        escolha = int.Parse(Console.ReadLine()); 
                        Console.Clear(); 
                                                
                        if(escolha == 1){
                            int valor;
                            Console.Write("Informe o valor a ser inserido: ");
                            valor = int.Parse(Console.ReadLine());

                            fila.inserir(vetor, valor, ref referencia);
                            Console.WriteLine("Valor inserido!");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 2){
                            Console.WriteLine($"Valor removido: {fila.remover(vetor, ref referencia)}");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if(escolha == 3){
                            fila.mostrar(vetor, ref referencia);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        
                        else{
                            Console.Clear();
                            break;
                        }    
                    }
                    Console.Clear();
                }

                else{
                    Console.Clear();
                    break;
                }
            }
        }
    }
}