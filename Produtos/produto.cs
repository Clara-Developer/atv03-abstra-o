namespace Produtos
{
    public class produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Estoque { get; set; }

        public produto(int codigo, string nome, double preço, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preço = preço;
            Estoque = estoque;

        }

        public void ValorEstoque()
        {
            Console.WriteLine($" Temos {Estoque} unidades de {Nome} no estoque.");
        }
    }
}
   