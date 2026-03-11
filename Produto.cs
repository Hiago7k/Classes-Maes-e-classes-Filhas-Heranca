

namespace Classes_Maes_e_classes_Filhas_Heranca;

abstract class Produto
{
    private string imagem;
    public DateTime DataCompra { get; }

    public string Nome { get;  }
    public string Descricao { get; }
    public decimal Preco { get; protected set; }
    // Aqui invez de termos Notas e Produtos passamos direto o agrupamento deles
    public Avaliacao Avaliacao { get; private set; }



    public Produto(string nome, string descricao, decimal preco, string imagem)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Imagem = imagem;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto / 100);
    }

    public void AlterarPrecoComDesconto(int desconto)
    {
        Preco = Preco - desconto;
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
        // Criar uma avaliacao de verdade
        Avaliacao = new Avaliacao(nota, comentario);
    }

    public abstract void Entregar(string endereco);
}
