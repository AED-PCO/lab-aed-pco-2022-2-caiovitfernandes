using celulas;
namespace lista{
    class metodos{
        public static void inserir(ref elemento primeiro, ref elemento ultimo, elemento novo, int posicao){
            if(posicao < 0){
                Console.WriteLine("Posição inválida!");
            }

            else if(primeiro == ultimo){
                primeiro.proximo = novo;
                ultimo = novo;
            }

            else if(posicao == 0){
                novo.proximo = primeiro.proximo;
                primeiro.proximo = novo;
            }

            else{
                elemento pesquisado = primeiro.proximo;
            
                for(int i = 0; i <= posicao; i++){
                    if(pesquisado == ultimo){
                        ultimo.proximo = novo;
                        ultimo = novo;
                        i = posicao;
                    }
                    else if(i == posicao - 1){
                        elemento auxiliar = pesquisado.proximo;
                        pesquisado.proximo = novo;
                        novo.proximo = auxiliar;
                    }
                    else{
                        pesquisado = pesquisado.proximo;
                    }
                }
            }   
        }

        public static elemento remover(ref elemento primeiro, ref elemento ultimo, int posicao){
            elemento pesquisado = primeiro.proximo;
            elemento removido = new elemento();

            if(primeiro == ultimo){
                Console.Clear();
                Console.WriteLine("Impossível remover. Lista vazia!");
                Console.ReadLine();
            }
            else if(posicao == 0){
                removido = primeiro.proximo;
                if(primeiro.proximo == ultimo){
                    ultimo = primeiro;
                }
                else{
                    primeiro.proximo = primeiro.proximo.proximo;
                }
            }
            else{
                for(int i = 0; i <= posicao; i++){
                    if(pesquisado == ultimo){
                        Console.WriteLine($"A posição especificada não existe na fila. A fila tem {i + 1} elementos, ou seja {i} posições.");
                        break;
                    }
                    else if(pesquisado.proximo == ultimo && i == posicao - 1){
                        removido = pesquisado.proximo;
                        ultimo = pesquisado;
                    }
                    else if(i == posicao - 1){
                        removido = pesquisado.proximo;
                        pesquisado.proximo = pesquisado.proximo.proximo;
                        break;
                    }
                    else{
                        pesquisado = pesquisado.proximo;
                    }
                }
            }
            return removido;
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Lista Vazia!");
                pesquisar = primeiro;
            }
            else{
                pesquisar = primeiro.proximo;
            }
            while(pesquisar != ultimo){
                Console.WriteLine(pesquisar.Aluno.nome);
                pesquisar = pesquisar.proximo;
            }
            Console.WriteLine(ultimo.Aluno.nome);
        }
    }
}