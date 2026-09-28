public class Comentario
{
    public string Nome { get; private set; }
    public string Texto { get; private set; }

    public Comentario(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }
}