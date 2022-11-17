using celulas;
namespace pilha{
    class metodos{
        public static void inserir(ref elemento ultimo, elemento novo){
            ultimo.proximo = novo;
        }

        public static elemento remover(ref elemento ultimo, ref elemento primeiro){
            if(primeiro == ultimo){
                Console.Clear();
                Console.WriteLine("A pilha está vazia");
                Console.ReadLine();
                return new elemento();
            }
            else{
                elemento removido = ultimo;

                elemento pesquisar = primeiro;
            
                while(pesquisar.proximo != ultimo){
                    pesquisar = pesquisar.proximo;
                }
                ref elemento refPesquisa = ref pesquisar;
                ultimo = refPesquisa;

                return removido;
            }
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Pilha Vazia!");
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
        public static void mostrarValor(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Pilha Vazia!");
                pesquisar = primeiro;
            }
            else{
                pesquisar = primeiro.proximo;
            }
            while(pesquisar != ultimo){
                Console.WriteLine(pesquisar.Aluno.valor);
                pesquisar = pesquisar.proximo;
            }
            Console.WriteLine(ultimo.Aluno.valor);
        }
    }

}