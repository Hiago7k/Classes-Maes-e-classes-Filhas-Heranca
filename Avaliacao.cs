namespace Classes_Maes_e_classes_Filhas_Heranca;

 class Avaliacao
{
    public Avaliacao(int nota, string comentario)
    {
        Nota = nota;
        Comentario = comentario;
    }

    public int Nota { get; private set; }
    public string Comentario { get; private set; }
}
