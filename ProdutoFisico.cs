

namespace Classes_Maes_e_classes_Filhas_Heranca;

 class ProdutoFisico : Produto
{
    public int Estoque { get;  }

    public ProdutoFisico(string nome, string descricao, decimal preco, string imagem)
        : base(nome, descricao, preco, imagem)
    {
        this.Estoque = 2;
    }

    public bool EstaDisponivel()
    {
        return Estoque > 0;  
    }

}
