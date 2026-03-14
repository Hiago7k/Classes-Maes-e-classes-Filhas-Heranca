using Classes_Maes_e_classes_Filhas_Heranca;


// Criando ProdutoFisico com estoque zerado
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo Mecanico", 90.00m, "Imagem" );

Console.WriteLine($"{item1.Nome}");
Console.WriteLine($"{item1.Descricao}");
Console.WriteLine($"{item1.Preco}");
Console.WriteLine($"{item1.Estoque}");

item1.AlterarPrecoComDesconto(10.0m); // Utilizando %
Console.WriteLine($"{item1.Preco}");
item1.AlterarPrecoComDesconto(10); // Utilizando 10 reais off
Console.WriteLine($"{item1.Preco}");
item1.Entregar("Endereco fisico");


//item1.Avaliar(10, "Bom demaise");
//Console.WriteLine("Dados do item");
//Console.WriteLine($"Imagem: {item1.Imagem}");
//item1.Imagem = "Nova Imagem";
//Console.WriteLine($"Imagem {item1.Imagem}"); 
//Console.WriteLine($"{item1.Avaliacao.Comentario}");
//Console.WriteLine($"{item1.Avaliacao.Nota}");

Console.WriteLine();
// Criando ProdutoFisico com outro construtor que possui estoque
ProdutoFisico item2 = new ProdutoFisico("Curso", "BackEnd", 1000.00m, "Imagem", 23);
Console.WriteLine($"{item2.Nome}");
Console.WriteLine($"{item2.Descricao}");
Console.WriteLine($"{item2.Preco}");
Console.WriteLine($"{item2.Estoque}");
item2.Entregar("hiago7k@gmail.com");

Console.WriteLine();

Pedido pedido = new Pedido(1, "Hiago", 100.00m);
pedido.AdicionarProduto(item1);
pedido.AdicionarProduto(item2);
pedido.ExibirResumo();

BancoDeDados banco = new BancoDeDados();
var produto = (ProdutoFisico)banco.BuscarProdutoPeloNome("Teclado");

Console.WriteLine($"{produto.Nome}");
Console.WriteLine($"{produto.Descricao}");
Console.WriteLine($"{produto.Preco}");
Console.WriteLine($"{produto.Estoque}");



Console.WriteLine("aaaa");
Console.WriteLine("Salving commits streak on weekend");
