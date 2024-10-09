using carros;

Carros carro1 = new Carros("Chevrolet", "Captiva 2012", 110);
Carros carro2 = new Carros("Hyundai", "Tucson 2023", 130);
Carros carro3 = new Carros("Troller", "T4", 100);


Console.WriteLine("O modelo " + carro1.Modelo + ", é da marca " + carro1.Marca + " e está em uma velocidade de " + carro1.Velocidade + "(Km/h)");
carro1.Aceleração();
carro1.Desacelerção();

Console.WriteLine("O modelo " + carro2.Modelo + ", é da marca " + carro2.Marca + " e está em uma velocidade de " + carro2.Velocidade + "(Km/h)");
carro2.Aceleração();
carro2.Desacelerção();

Console.WriteLine("O modelo " + carro3.Modelo + ", é da marca " + carro3.Marca + " e está em uma velocidade de " + carro3.Velocidade + "(Km/h)");
carro3.Aceleração();
carro3.Desacelerção();

Console.ReadKey();
