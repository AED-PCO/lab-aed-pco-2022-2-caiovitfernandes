using pilha;
using lista;
using celulas;

namespace calculadoraPolonesa{
    class metodos{
        public static void calculadora(string notacao){
            string[] operacoes = notacao.Split(" ");

            elemento primeiro = new elemento();
            elemento ultimo = primeiro;

            for(int i = 0; i < operacoes.Length; i++){
                elemento novo = new elemento();
                if(operacoes[i] == "+" || operacoes[i] == "-" || operacoes[i] == "*" || operacoes[i] == "/"){
                    float operando1 = pilha.metodos.remover(ref ultimo, ref primeiro).Aluno.valor;
                    float operando2 = pilha.metodos.remover(ref ultimo, ref primeiro).Aluno.valor;

                    switch(operacoes[i]){
                        case "+":
                            novo.Aluno.valor = operando1 + operando2;
                            pilha.metodos.inserir(ref ultimo, novo);
                        break; 
                         case "-":
                            novo.Aluno.valor = operando1 - operando2;
                            pilha.metodos.inserir(ref ultimo, novo);
                        break; 
                         case "*":
                            novo.Aluno.valor = operando1 * operando2;
                            pilha.metodos.inserir(ref ultimo, novo);
                        break; 
                         case "/":
                            novo.Aluno.valor = operando1 / operando2;
                            pilha.metodos.inserir(ref ultimo, novo);
                        break;
                    }
                }
                else{
                    novo.Aluno.valor = float.Parse(operacoes[i]);
                    pilha.metodos.inserir(ref ultimo, novo);
                }
                pilha.metodos.mostrarValor(ref primeiro, ref ultimo);
            }
        }
    }
}