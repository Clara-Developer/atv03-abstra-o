namespace carros
{
    public class Carros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public Carros(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }
        public void Aceleração()
        {
            Console.WriteLine($" Sua velocidade atual é de {Velocidade} em 2.7s");
        }
        public void Desacelerção()
        {
            Console.WriteLine($" Sua dessaceleração é de {Velocidade} - 180km/h.");
        }
    }
}

 
