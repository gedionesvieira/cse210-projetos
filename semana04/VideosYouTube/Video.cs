using System.Collections.Generic;

public class Video
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int DuracaoSegundos { get; private set; }

    private List<Comentario> comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracaoSegundos)
    {
        Titulo = titulo;
        Autor = autor;
        DuracaoSegundos = duracaoSegundos;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        comentarios.Add(comentario);
    }

    public int ObterQuantidadeDeComentarios()
    {
        return comentarios.Count;
    }

    public List<Comentario> ObterComentarios()
    {
        return comentarios;
    }
}
