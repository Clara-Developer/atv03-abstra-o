namespace livro
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }   
        public int Anodelançamento { get; set; }


   


        public Livro(string titulo, string autor, string editora, int anodelançamento) 
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Anodelançamento = anodelançamento;
        }

    }
}

