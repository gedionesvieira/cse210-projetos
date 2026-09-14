public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Qual foi a melhor parte do seu dia?",
        "O que você aprendeu hoje?",
        "Como você se sentiu hoje?"
    };
    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();
        int indice = aleatorio.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}