using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("João", 3, 16);

        string text =
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Pressione Enter para esconder palavras ou digite 'sair': ");

            string answer = Console.ReadLine();

            if (answer != null && answer.ToLower() == "sair")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Todas as palavras foram escondidas.");
    }
}