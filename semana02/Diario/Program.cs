using System;

class Program
{
    static void Main(string[] args)
    {
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        Diario diario = new Diario();

        string pergunta = gerador.ObterPerguntaAleatoria();

        Console.WriteLine(pergunta);
        Console.Write("Resposta: ");
        string resposta = Console.ReadLine();

        Registro registro = new Registro();
        registro._data = DateTime.Now.ToShortDateString();
        registro._textoPergunta = pergunta;
        registro._textoResposta = resposta;

        diario.AdicionarRegistro(registro);

        Console.WriteLine();
        diario.ExibirTodos();
    }
}