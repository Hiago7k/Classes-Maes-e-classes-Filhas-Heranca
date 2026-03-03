

namespace Classes_Maes_e_classes_Filhas_Heranca;

 class ProdutoDigital : Produto
{
     private string linkDownload;


    public ProdutoDigital(string nome, string descricao, decimal preco, string imagem, string linkDownload)
        : base(nome, descricao, preco, imagem)
        // Partes inicias vao usar o nosso construtor Base
    {
        // E a parte especifica vai receber o linkdownload do parametro
        this.LinkDownload = linkDownload;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload;
        }
        set
        {
            if (value.Length > 0)
                this.linkDownload = value;
        }
    }


}
