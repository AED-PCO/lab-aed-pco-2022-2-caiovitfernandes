namespace programa{
    class program{
        static void Main(string[] Args){
            int escolha = 1;

            while (escolha >= 1 && escolha <= 3){
                Console.Clear();
                Console.Write("Escolha qual estrutura utilizar:\n1 - Lista circular estática\n2 - Lista duplamente encadeada\n3 - Lista circular dinâmica\n0 -  Sair do programa\n\nResposta: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                if(escolha == 1){ //Lista circular estática
                    int resposta = 1;

                    while (resposta >= 1 && resposta <= 3){
                        Console.Clear();
                        Console.Write("Escolha qual método utilizar:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 -  Sair do programa\n\nResposta: ");
                        resposta = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if(resposta == 1){ //Inserir
                            
                        }

                        else if(resposta == 2){ //Remover

                        }

                        else if(resposta == 3){ //Mostrar

                        }

                        else{}
                    }
                }

                else if(escolha == 2){ //Lista duplamente encadeada
                    int resposta = 1;

                    while (resposta >= 1 && resposta <= 3){
                        Console.Clear();
                        Console.Write("Escolha qual método utilizar:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 -  Sair do programa\n\nResposta: ");
                        resposta = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if(resposta == 1){ //Inserir
                            
                        }

                        else if(resposta == 2){ //Remover

                        }

                        else if(resposta == 3){ //Mostrar

                        }

                        else{}
                    }
                }

                else if(escolha == 3){ //Lista circular dinâmica
                    int resposta = 1;

                    while (resposta >= 1 && resposta <= 3){
                        Console.Clear();
                        Console.Write("Escolha qual método utilizar:\n1 - Inserir\n2 - Remover\n3 - Mostrar\n0 -  Sair do programa\n\nResposta: ");
                        resposta = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if(resposta == 1){ //Inserir
                            
                        }

                        else if(resposta == 2){ //Remover

                        }

                        else if(resposta == 3){ //Mostrar

                        }

                        else{}
                    }
                }

                else{}
            }
        }
    }
}
