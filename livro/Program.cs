
using livro;

Livro livro1 = new Livro("Arma Escarlate", "Renata Ventura", "Novo século", 2011);
Livro livro2 = new Livro("Vidas Eternas", "Robert Curran", "Darkside", 2019);
Livro livro3 = new Livro("A maldição do mar", "Shea Enshaw", "Galera", 2021);

Console.WriteLine("O nome do livro é: " + livro1.Titulo + ", sua autora é a " + livro1.Autor + ", ele é da editora " + livro1.Editora + " e foi publicado em " + livro1.Anodelançamento);
Console.WriteLine("O nome do livro é: " + livro2.Titulo + ", sua autora é a " + livro2.Autor + ", ele é da editora " + livro2.Editora + " e foi publicado em " + livro2.Anodelançamento);
Console.WriteLine("O nome do livro é: " + livro3.Titulo + ", sua autora é a " + livro3.Autor + ", ele é da editora " + livro3.Editora + " e foi publicado em " + livro3.Anodelançamento);
Console.ReadKey();
