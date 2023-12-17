using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista)// ordena as musicas pelos artistas em ordem crescente
            .Select(musicas => musicas.Artista)// selecionas os artistas
            .Distinct()//tira os iguais
            .ToList();// transforma em lista
        Console.WriteLine("Lista dos artistas ordenados:");
        foreach (var artistas in artistasOrdenados)
        {
            Console.WriteLine($"- {artistas}");
        }
    }
}
