using Produtos;

produto produto1 = new produto(789533, "Lápis", 1.50, 50);
produto produto2 = new produto(1775355, "Borrachas", 2.00, 35);
produto produto3 = new produto(88887621, "Canetas", 2.59, 70);




Console.WriteLine("Seu produto é o: " + produto1.Nome + " portador do código " + produto1.Codigo + ", cujo o preço é R$" + produto1.Preço + " e possuimos " + produto1.Estoque + " unidades no estoque.");
produto1.ValorEstoque();
Console.WriteLine("Seu produto é o: " + produto2.Nome + " portador do código " + produto2.Codigo + ", cujo o preço é R$" + produto2.Preço + " e possuimos " + produto2.Estoque + " unidades no estoque.");
produto2.ValorEstoque();
Console.WriteLine("Seu produto é o: " + produto3.Nome + " portador do código " + produto3.Codigo + ", cujo o preço é R$" + produto3.Preço + " e possuimos " + produto3.Estoque + " unidades no estoque.");
produto3.ValorEstoque();
Console.ReadKey();

