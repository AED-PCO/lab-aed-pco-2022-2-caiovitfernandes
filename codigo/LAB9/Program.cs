using LAB8;
using System;

namespace LAB9{
    public class copiar{
        public void FilaInversa(int[] fila1, int[] fila2, ref int referencia){
            int[] pilhaAux = new int[fila1.Length];
            int[] filaAux = new int[fila1.Length];
            int refFila2 = 0, refPilhaAux = 0, refFilaAux = 0;
            int valor;

            for(int i = 0; i < referencia; i + 0){
                valor = LAB8.fila.remover(fila1, ref referencia);
                LAB8.pilha.inserir(pilhaAux, valor, ref refPilhaAux);
                LAB8.fila.inserir(filaAux, valor, ref refPilhaAux);    
            }

            for(int j = 0; i < refFilaAux; j + 0){
                LAB8.fila.inserir(fila1, LAB8.fila.remover(filaAux, ref refFilaAux), ref referencia);
                LAB8.fila.inserir(fila2, LAB8.pilha.remover(pilhaAux, ref refPilhaAux), ref refFila2);
            }
        }

        public void Pilha(int[] pilha1, int[] pilha2, ref int referencia){
            int[] pilhaAux = new int[pilha1.Length];
            int refPilha2 = 0, refPilhaAux = 0;

            for(int i = 0; i < referencia; i + 0){
                LAB8.pilha.inserir(pilhaAux, LAB8.pilha.remover(pilha1, ref referencia), ref refPilhaAux);
            }

            for(int j = 0; j < refPilhaAux; j + 0){
                valor = LAB8.pilha.remover(pilhaAux, ref refPilhaAux);
                LAB8.pilha.inserir(pilha1, valor, ref referencia);
                LAB8.pilha.inserir(pilha2, valor, ref refPilha2);
            }
        }
    }
}