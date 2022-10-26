using System.IO;
using System.Diagnostics;

namespace LAB7{
    class quest1{
        static void buscaArq(string frase){
            int iguais = 0, diferentes = 0;
            var arquivo = File.ReadAllLines("arq1.txt");
            foreach(string linha in arquivo){
                if(frase == linha){
                    Console.WriteLine("IGUAL");
                    iguais++;
                }
                else{
                    Console.WriteLine("DIFERENTE");
                    diferentes++;
                }
            }

            Console.WriteLine($"Linhas iguais: {iguais}\nLinhas diferentes: {diferentes}");
        }
        public static void programa(){
            Console.Write("Digite uma frase para ser buscada nas linhas do arquivo: ");
            string busca = Console.ReadLine();

            buscaArq(busca);
        }
    }

    class quest2{
        static int funcRec1(int a){
            if (a <= 1)
                return 0;
            else
                return funcRec1((a - 2) + 5);
        }
        public static void programa(){
            try{
                funcRec1(6);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }

    class quest3{
        static string leInverte(string nomeDoArquivo){
            string[] primeiraLinha = File.ReadAllLines(nomeDoArquivo);
            char[] resultadoChar, linhaChar;
            resultadoChar =  new char[primeiraLinha[0].Length];
            linhaChar = primeiraLinha[0].ToCharArray();

            for(int i = 0; i < linhaChar.Length; i++){
                resultadoChar[linhaChar.Length - 1 - i] = linhaChar[i];
            }
            string resultado = new String(resultadoChar);
            return resultado;
        }

        static void escreve(string nomeDoArquivo, string termo){
            using (StreamWriter arq = new StreamWriter(nomeDoArquivo)){
                arq.WriteLine(termo);
            }
            Console.WriteLine($"\"{termo}\" foi gravado no arquivo de saída");
        }
        public static void programa(){
            escreve("saida.txt" ,leInverte("entrada.txt"));
        }
    }

    class quest4{
        static void swap(long[]vetor, int posA, int posB){
            long aux = vetor[posA];
            vetor[posA] = vetor[posB];
            vetor[posB] = aux;
        }
        static void quickSort(long[] vetor, int inicio, int fim){
            if(inicio < fim){
                long pivo;
                int part;
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

        static long[] geradorDeCPF(int quantidade){
            long[] resultado = new long[quantidade];
            for(int i = 0; i < quantidade; i++){
                int soma = 0, resto = 0;
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                Random rnd = new Random();
                string semente = rnd.Next(100000000, 999999999).ToString();

                for (int j = 0; j < 9; j++)
                    soma += int.Parse(semente[j].ToString()) * multiplicador1[j];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                semente = semente + resto;
                soma = 0;

                for (int k = 0; k < 10; k++)
                    soma += int.Parse(semente[k].ToString()) * multiplicador2[k];

                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                semente = semente + resto;
                resultado[i] = long.Parse(semente);
            }

            return resultado;
        }

        public static void programa(){
            long[] cpfs = geradorDeCPF(50000);

            var cronometro =  new Stopwatch();
            cronometro.Start();
            quickSort(cpfs, 0, 49999);
            cronometro.Stop();

            for(int i = 0; i < 50000; i++){
                Console.Write($"{cpfs[i]} ");
            }

            Console.WriteLine($"\nTempo gasto na ordenação: {cronometro.ElapsedMilliseconds.ToString()} milisegundos");
        }
    }

    class quest5{
        static int funcao(int a, int[] v){
            if(a == 1)
                return v[0];
            else{
                int x;
                x = funcao(a - 1, v);
                if(x > v[a - 1])
                    return x;
                else
                    return v[a - 1];
            }
        }
        public static void programa(){
            int[] vetor = new int[7]{10, 5, 7, 15, 22, 9, 30};
            Console.WriteLine($"A função retornou: {funcao(6, vetor)}");
        }
    }
    class program{

        static void Main(string[] args){
            int menu = 1;
            
            while(menu >= 1 && menu <= 5){
                Console.Write("Escreva o número da questão que deseja rodar (questões de 1 a 5): ");
                menu = int.Parse(Console.ReadLine());

                if(menu == 1){
                    quest1.programa();
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(menu == 2){
                    quest2.programa();
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(menu == 3){
                    quest3.programa();
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(menu == 4){
                    quest4.programa();
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(menu == 5){
                    quest5.programa();
                    Console.Write("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }

                else{
                    break;
                }
            }

        }
    }
}