using ScreenSound.Modelos;
using System.Linq;


namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero) //Seleciona os generos
            .Distinct() //Garante que os generos são distintos
            .ToList(); // Transforma em uma lista

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero.Contains(genero))//filtra da lista quando a musica contem o genero
            .Select(musicas => musicas.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach(var artista  in artistasPorGeneroMusical) { Console.WriteLine($"- {artista}"); }
        

    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista.Equals(artista))// usar Where para pegar subconjuntos
            .ToList();
        Console.WriteLine($"{artista}: ");
        foreach (var musica in musicasDoArtista) { Console.WriteLine($"- {musica.Nome}"); }

    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();

        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }

}
