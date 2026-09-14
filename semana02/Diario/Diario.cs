public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }
    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
            Console.WriteLine();
        }
    }
    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter escritor = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                escritor.WriteLine(registro._data);
                escritor.WriteLine(registro._textoPergunta);
                escritor.WriteLine(registro._textoResposta);
            }
        }
        Console.WriteLine("Diario Salvo com sucesso.");
    }
    public void CarregarDoArquivo(string arquivo)
    {
        _registros.Clear();
        using (StreamReader leitor = new StreamReader(arquivo))
        {
            while (!leitor.EndOfStream)
            {
                string data = leitor.ReadLine();
                string pergunta = leitor.ReadLine();
                string resposta = leitor.ReadLine();

                Registro registro = new Registro();

                registro._data = data;
                registro._textoPergunta = pergunta;
                registro._textoResposta = resposta;

                _registros.Add(registro);  
            }
        }
        Console.WriteLine("Diario carregado com sucesso.");
    }
}