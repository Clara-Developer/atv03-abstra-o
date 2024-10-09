using aluno;

Aluno Aluno1 = new Aluno(4964, "Ana Clara", 2007, "clarinha.rsilva27@gmail.com");
Aluno Aluno2 = new Aluno(1755, "Isadora", 2007, "isadora.dias67@gmail.com");
Aluno Aluno3 = new Aluno(2021, "Natalia", 2007, "Nat.santos389@gmail.com");


Console.WriteLine("Você é a: " + Aluno1.Nome + ", seu RM é " + Aluno1.RM + ", Você nasceu no ano de " + Aluno1.Nascimento + " e porta o email " + Aluno1.Email);
Console.WriteLine("Você é a: " + Aluno2.Nome + ", seu RM é " + Aluno2.RM + ", Você nasceu no ano de " + Aluno2.Nascimento + " e porta o email " + Aluno2.Email);
Console.WriteLine("Você é a: " + Aluno3.Nome + ", seu RM é " + Aluno3.RM + ", Você nasceu no ano de " + Aluno3.Nascimento + " e porta o email " + Aluno3.Email);
Console.ReadKey();