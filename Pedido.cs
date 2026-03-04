
namespace Classes_Maes_e_classes_Filhas_Heranca;

internal class Pedido : IExpiravel
{
    private bool pago;

    public Pedido(bool pago, int id, string cliente, DateTime data, decimal valorTotal)
    {
        pago = false;
        Id = id;
        Cliente = cliente;
        Data = DateTime.Now;
        ValorTotal = valorTotal;
    }

    public int Id { get;}
    public string Cliente { get;  }
    public DateTime Data { get; }
    public decimal ValorTotal { get;  }
    public Avaliacao Avaliacao { get; }


    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Cliente}");
        Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
        Console.WriteLine($"Status: {(EstaExpirado() ? "Expirado" : "Válido")}");
    }

    public bool EstaExpirado()
    {
        return !pago && DateTime.Now > Data.AddMinutes(15);
    }

    public void Pagar()
    {
        pago = true;
    }
}
