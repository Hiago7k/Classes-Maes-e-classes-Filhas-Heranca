

namespace Classes_Maes_e_classes_Filhas_Heranca;

abstract class Produto
{
    private string imagem;
    public DateTime DataCompra { get; }

    public string Nome { get;  }
    public string Descricao { get; }
    public decimal Preco { get;  }
    public int Nota { get; private set; }
    public string Comentario { get; private set; }



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

    public bool EstaExpirado()
    {
        return DateTime.Now > DataCompra.AddYears(2);
    }

    public void Avaliar(int nota, string comentario)
    {
        Nota = nota;
        Comentario = comentario;
    }
}
