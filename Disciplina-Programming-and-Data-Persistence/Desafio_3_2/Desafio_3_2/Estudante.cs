namespace Desafio_3_2
{
    public class Estudante
    {

        private string nome;
        private int idade;
        private int serie;
        private float nota;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Serie { get => serie; set => serie = value; }
        public float Nota { get => nota; set => nota = value; }

        public Estudante(string nome, int idade, int serie, float nota)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Serie = serie;
            this.Nota = nota;
        }
    }
}