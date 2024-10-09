namespace aluno
{
    public class Aluno
    {
        public int RM { get; set; }
        public string Nome { get; set; }
        public int Nascimento { get; set; }
        public string Email { get; set; }

        public Aluno(int rm, string nome, int nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
     
        }


    }
}
