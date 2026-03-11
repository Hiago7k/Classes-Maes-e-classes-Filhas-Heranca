namespace Classes_Maes_e_classes_Filhas_Heranca;

internal class BancoDeDados
{
    List<Produto> produtos = new List<Produto>()
    {
        new ProdutoDigital("Curso", "OO em C#", 100.00m, "Imagem ilustrativa", "Link")
        new ProdutoFisico("Teclado", "Modelo compacto", 120.00m, "Imagem ilustrativa")

    };

    public Produto BuscarProdutoPeloNome(string nome)
    {
        foreach (var p in produtos)
        {
            if (p.Nome.Equals(nome))
            {
                return p;
            }
        }
        return null;
    }
}

