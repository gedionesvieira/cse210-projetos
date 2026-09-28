using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Como estudar programação",
            "Canal Aprenda C#",
            645
        );

        video1.AdicionarComentario(
            new Comentario("Ana", "A explicação foi muito clara!")
        );

        video1.AdicionarComentario(
            new Comentario("Bruno", "Vou aplicar essas dicas nos meus estudos.")
        );

        video1.AdicionarComentario(
            new Comentario("Carla", "Gostei especialmente do exemplo prático.")
        );

        video1.AdicionarComentario(
            new Comentario("Diego", "Conteúdo excelente para iniciantes.")
        );

        videos.Add(video1);

        Video video2 = new Video(
            "Introdução à programação orientada a objetos",
            "Código Fácil",
            820
        );

        video2.AdicionarComentario(
            new Comentario("Marina", "Agora entendi melhor o que são classes.")
        );

        video2.AdicionarComentario(
            new Comentario("Rafael", "O exemplo de objetos ajudou bastante.")
        );

        video2.AdicionarComentario(
            new Comentario("Julia", "Vídeo muito bem explicado.")
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Gostaria de ver mais exercícios assim.")
        );

        videos.Add(video2);

        Video video3 = new Video(
            "Dicas para organizar seus estudos",
            "Estude Melhor",
            510
        );

        video3.AdicionarComentario(
            new Comentario("Sofia", "A organização fez muita diferença.")
        );

        video3.AdicionarComentario(
            new Comentario("Pedro", "Vou criar um horário de estudos.")
        );

        video3.AdicionarComentario(
            new Comentario("Beatriz", "Dicas simples e úteis.")
        );

        video3.AdicionarComentario(
            new Comentario("Gustavo", "Obrigado por compartilhar!")
        );

        videos.Add(video3);

        Video video4 = new Video(
            "Projetos simples em C#",
            "Dev Iniciante",
            735
        );

        video4.AdicionarComentario(
            new Comentario("Laura", "Esse projeto parece divertido.")
        );

        video4.AdicionarComentario(
            new Comentario("Felipe", "Vou tentar fazer uma versão própria.")
        );

        video4.AdicionarComentario(
            new Comentario("Nina", "Aprendi vários conceitos novos.")
        );

        video4.AdicionarComentario(
            new Comentario("Caio", "Espero ver a continuação.")
        );

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.DuracaoSegundos} segundos");
            Console.WriteLine(
                $"Quantidade de comentários: {video.ObterQuantidadeDeComentarios()}"
            );

            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine(
                    $"- {comentario.Nome}: {comentario.Texto}"
                );
            }

            Console.WriteLine();
        }
    }
}