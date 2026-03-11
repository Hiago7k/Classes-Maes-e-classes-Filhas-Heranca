using Classes_Maes_e_classes_Filhas_Heranca;

ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo Mecanico", 90.00m, "Imagem" );

Console.WriteLine($"{item1.Nome}");
Console.WriteLine($"{item1.Descricao}");
Console.WriteLine($"{item1.Preco}");
Console.WriteLine($"{item1.Estoque}");

item1.Avaliar(10, "Bom demaise");
Console.WriteLine("Dados do item");
Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "Nova Imagem";
Console.WriteLine($"Imagem {item1.Imagem}"); 
Console.WriteLine($"{item1.Avaliacao.Comentario}");
Console.WriteLine($"{item1.Avaliacao.Nota}");





