class program{
    static void Main(string[] args){
        int menu = 1;

        while(menu < 7 && menu > 0){
            Console.Write("Selecione o exercício que deseja rodar:\n1 - Exercício 1\n2 - Exercício 2\n3 - Exercício 3\n4 - Exercício 4\n5 - Exercício 5\n6 - Exercício 6\n7 - Sair do programa\n\nEscolha: ");

            menu = int.Parse(Console.ReadLine());
            
            if(menu == 1){
                //Exercicio 1
                Console.WriteLine("-----Exercício 1-----");
                Console.Write("Digite um número para calcular o fatorial: ");
                int numero = int.Parse(Console.ReadLine());

                static double fat(int num){
                    if(num == 2){
                        return 2;
                    }
                    else{
                        return num * fat(num - 1);
                    }
                }

                Console.WriteLine($"O fatorial de {numero} é {fat(numero)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 2){
                //Exercício 2
                Console.WriteLine("-----Exercício 2-----");
                Console.WriteLine("Digite dois números inteiros para serem multiplicados:");
                int numeroA = int.Parse(Console.ReadLine());
                Console.WriteLine("*");
                int numeroB = int.Parse(Console.ReadLine());

                static int multiplicacao(int num1, int num2){
                    if(num1 < 0 && num2 < 0){
                        num1 *= -1;
                        num2 *= -1;
                    }

                    if(num2 == 1){
                        return num1;
                    }
                    else if(num2 == 0){
                        return 0;
                    }
                    else if(num2 > 0){
                        return num1 + multiplicacao(num1, (num2 - 1)); 
                    }
                    else{
                        return -num1 + multiplicacao(num1, (num2 + 1));
                    }
                }

                Console.WriteLine($"{numeroA} * {numeroB} = {multiplicacao(numeroA, numeroB)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 3){
                //Exercício 3
                Console.WriteLine("-----Exercício 3-----");
                Console.WriteLine("Digite dois números inteiros, sendo que o primeiro será elevado ao segundo:");
                int numA = int.Parse(Console.ReadLine());
                Console.WriteLine("^");
                int numB = int.Parse(Console.ReadLine());

                static int exp(int num1, int num2){
                    if(num2 == 1){
                        return num1;
                    }
                    else{
                        int aux = num1 * exp(num1, (num2 - 1));
                        return aux;
                    }
                }

                Console.WriteLine($"{numA} ^ {numB} = {exp(numA, numB)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 4){
                //Exercício 4
                Console.WriteLine("-----Exercício 4-----");
                Console.WriteLine("Escreva uma frase:");
                string frase = Console.ReadLine();
                char[] vetor = frase.ToCharArray();   
                Console.Write("Procurar ocorrências da letra: ");
                char letra = char.Parse(Console.ReadLine());

                static int ocorrencias(char[] str, char caractere, int aux){
                    if(aux == (str.Length - 1)){
                        if(str[aux] == caractere){
                            return 1;
                        }
                        else{
                            return 0;
                        }
                    }
                    else{
                        int resultado = 0;
                        if(str[aux] == caractere){
                            resultado = 1 + (ocorrencias(str, caractere, (aux + 1)));
                            return resultado;
                        }
                        else{
                            resultado = 0 + (ocorrencias(str, caractere, (aux + 1)));
                            return resultado;
                        }
                    }
                }

                Console.WriteLine($"Na frase \"{frase}\", a letra {letra} aparece {ocorrencias(vetor, letra, 0)} vezes");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 5){
                //Exercício 5
                Console.WriteLine("-----Exercício 5-----");
                Console.Write("Escolha um tamanho para o vetor: ");
                int tamanho = int.Parse(Console.ReadLine());
                int[] vet = new int[tamanho];
                Console.WriteLine($"Agora digite os {tamanho} números do vetor:");
                
                for(int i = 0; i < tamanho; i++){
                    vet[i] = int.Parse(Console.ReadLine());
                }

                static int somaPares(int[] vetor, int aux){
                    if(aux == vetor.Length - 1){
                        if(vetor[aux] % 2 == 0){
                            return vetor[aux];
                        }
                        else{
                            return 0;
                        }
                    }
                    else{
                        int resultado = 0;
                        if(vetor[aux] % 2 == 0){
                            resultado = vetor[aux] + somaPares(vetor, (aux + 1));
                            return resultado;
                        }
                        else{
                            resultado = 0 + somaPares(vetor, (aux + 1));
                            return resultado;
                        }
                    }
                }

                Console.WriteLine($"No vetor acima, a soma dos números pares é {somaPares(vet, 0)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else if(menu == 6){
                //Exercício 6
                Console.WriteLine("-----Exercício 6-----");
                Console.WriteLine("Digite uma frase para retirar as vogais:");
                string frase2 = Console.ReadLine();
                char[] vetor2 = frase2.ToCharArray();

                static Boolean eVogal(char letra){
                    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
                        return true;
                    }
                    else{
                        return false;
                    }
                }

                static string tiraVogais(char[] vet, int pos){
                    if(pos == vet.Length - 1){
                        if(eVogal(vet[pos])){
                            return "";
                        }
                        else{
                            return vet[pos].ToString();
                        }
                    }
                    else{
                        string resultado = "";
                        if(eVogal(vet[pos])){
                            resultado = "" + tiraVogais(vet, (pos + 1));
                            return resultado;
                        }
                        else{
                            resultado = vet[pos] + tiraVogais(vet, (pos + 1));
                            return resultado;
                        }
                    }
                }

                Console.WriteLine($"Esta frase sem as vogais fica: {tiraVogais(vetor2, 0)}");
                Console.Write("\nEnter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else{
                Console.WriteLine("Fim do Programa!");
            }
        }        
    }
}



