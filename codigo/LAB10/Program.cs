using celulas;
using pilha;
using fila;

namespace LAB10{
    class program{
        static void pilhaDinamica(){
            elemento primeiro = new elemento();
            elemento ultimo = primeiro;

            int resposta = 1;

            while(resposta >= 1 && resposta <= 3){
                Console.WriteLine("Escolha o que deseja:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Sair");
                resposta = int.Parse(Console.ReadLine());

                if(resposta == 1){
                    Console.Clear();
                    Console.WriteLine("Informe o nome do aluno:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    long matricula = long.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    int nota = int.Parse(Console.ReadLine());
                    
                    elemento novo = new elemento();
                    novo.Aluno.nome = nome;
                    novo.Aluno.matricula = matricula;
                    novo.Aluno.nota = nota;

                    pilha.metodos.inserir(ref ultimo, novo);
                    ultimo = novo;
                    Console.WriteLine("Aluno inserido com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(resposta == 2){
                    elemento removido = pilha.metodos.remover(ref ultimo, ref primeiro);
                    Console.Clear();
                    Console.WriteLine($"Aluno removido:\n{removido.Aluno.nome}");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(resposta == 3){
                    Console.Clear();
                    pilha.metodos.mostrar(ref primeiro, ref ultimo);
                    Console.ReadLine();
                    Console.Clear();
                }
                
                else{}
            }
            Console.Clear();
        }

        static void filaDinamica(){
            elemento primeiro = new elemento();
            elemento ultimo = primeiro;

            int resposta = 1;

            while(resposta >= 1 && resposta <= 3){
                Console.WriteLine("Escolha o que deseja:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Sair");
                resposta = int.Parse(Console.ReadLine());
                Console.Clear();

                if(resposta == 1){
                    Console.WriteLine("Informe o nome do aluno:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    long matricula = long.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    int nota = int.Parse(Console.ReadLine());
                    
                    elemento novo = new elemento();
                    novo.Aluno.nome = nome;
                    novo.Aluno.matricula = matricula;
                    novo.Aluno.nota = nota;

                    fila.metodos.inserir(ref ultimo, novo);
                    Console.WriteLine($"{novo.Aluno.nome} inserido com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(resposta == 2){
                    elemento removido = fila.metodos.remover(ref primeiro, ref ultimo);
                    Console.WriteLine($"Aluno removido: {removido.Aluno.nome}");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(resposta == 3){
                    fila.metodos.mostrar(ref primeiro, ref ultimo);
                    Console.ReadLine();
                    Console.Clear();
                }

                else{}
            }
            Console.Clear();
        }

        static void listaDinamica(){
            elemento primeiro = new elemento();
            elemento ultimo = primeiro;

            int resposta = 1;

            while(resposta >= 1 && resposta <= 3){
                Console.WriteLine("Escolha o que deseja:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 - Sair");
                resposta = int.Parse(Console.ReadLine());
                Console.Clear();

                if(resposta == 1){
                    Console.WriteLine("Informe o nome do aluno:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    long matricula = long.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    int nota = int.Parse(Console.ReadLine());
                    Console.WriteLine("Agora informe a posição em que deseja inserir:");
                    int posicao = int.Parse(Console.ReadLine());
                    if(posicao < 0){
                        Console.WriteLine("Posição inválida!");
                    }
                    else{
                        elemento novo = new elemento();
                        novo.Aluno.nome = nome;
                        novo.Aluno.matricula = matricula;
                        novo.Aluno.nota = nota;

                        lista.metodos.inserir(ref primeiro, ref ultimo, novo, posicao);
                        Console.WriteLine($"{novo.Aluno.nome} inserido com sucesso!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if(resposta == 2){
                    Console.WriteLine("Escolha em qual posição deseja remover:");
                    int posicao = int.Parse(Console.ReadLine());
                    elemento removido = lista.metodos.remover(ref primeiro, ref ultimo, posicao);
                    Console.WriteLine($"Aluno removido: {removido.Aluno.nome}");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(resposta == 3){
                    lista.metodos.mostrar(ref primeiro, ref ultimo);
                    Console.ReadLine();
                    Console.Clear();
                }

                else{}
            }
            Console.Clear();
        }

        static void Main(string[] args){
            int resposta = 1;
            while(resposta >= 1 && resposta <= 4){
                Console.Write("Escolha qual estrutura dinâmica deseja trabalhar:\n1 - Pilha\n2 - Fila\n3 - Lista\n4 - Calculadora de notação polonesa inversa\n0 - Sair\n\nResposta: ");
                resposta = int.Parse(Console.ReadLine());
                Console.Clear();

                if(resposta == 1){
                    pilhaDinamica();
                }

                else if(resposta == 2){
                    filaDinamica();
                }

                else if(resposta == 3){
                    listaDinamica();
                }

                else if(resposta == 4){
                    Console.WriteLine("Digite a equação em notação polonesa inversa: ");
                    Console.ReadLine();
                    Console.Clear();
                }
                
                else{}
            }
        }
    }
}