using celulas;
namespace fila{
    class metodos{
        public static void inserir(ref elemento ultimo, elemento novo){
            ultimo.proximo = novo;
            ultimo = ultimo.proximo;
        }

        public static elemento remover(ref elemento primeiro, ref elemento ultimo){
            if(primeiro == ultimo){
                Console.Clear();
                Console.WriteLine("Impossível remover. Fila Vazia!");
                Console.ReadLine();
                return new elemento();
            }
            elemento removido = primeiro.proximo;

            primeiro.proximo = primeiro.proximo.proximo;

            return removido;
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Fila Vazia!");
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