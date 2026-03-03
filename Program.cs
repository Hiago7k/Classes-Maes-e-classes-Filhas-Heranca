using Classes_Maes_e_classes_Filhas_Heranca;

ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo Mecanico", 90.00m, "Imagem" );

Console.WriteLine($"{item1.Nome}");
Console.WriteLine($"{item1.Descricao}");
Console.WriteLine($"{item1.Preco}");
Console.WriteLine($"{item1.Estoque}");

Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "Nova Imagem";
Console.WriteLine($"Imagem {item1.Imagem}");



Console.WriteLine();
ProdutoDigital item2 = new ProdutoDigital("Vip", "Acesso a Kits", 40.00m, "Vip para", "linkdowndloadbaixaqui");

Console.WriteLine($"{item2.Nome}");
Console.WriteLine($"{item2.Descricao}");
Console.WriteLine($"{item2.Preco}");
Console.WriteLine($"{item2.LinkDownload}");

Console.WriteLine($"Imagem: {item2.Imagem}");
item1.Imagem = "Desmontracao vip";
Console.WriteLine($"Imagem {item2.Imagem}");

