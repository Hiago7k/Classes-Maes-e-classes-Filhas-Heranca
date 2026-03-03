

namespace Classes_Maes_e_classes_Filhas_Heranca;

internal class Produto
{
    private string imagem;

    public string Nome { get;  }
    public string Descricao { get; }
    public decimal Preco { get;  }


    public Produto(string nome, string descricao, decimal preco, string imagem)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Imagem = imagem;
    }

    public string Imagem
    {
        get
        {
            return imagem;
        }
        set
        {
            if (value.Length > 0)
                this.imagem = value;
        }
    }

   
}
