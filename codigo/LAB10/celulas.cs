namespace celulas{
    class aluno{
        public string nome;
        public long matricula;
        public int nota;
        public float valor;
    }

    class elemento{
        public aluno Aluno = new aluno();
        public elemento proximo;
    }
}