using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{

    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };


    //JsonPropertyName associa a variavel Name com a "song" - não precisa ser utilizado se a variavel tem o mesmo nome da propriedade json
    [JsonPropertyName("song")]
    public string? Nome { get; set; }// o ? admite que a string pode ser nula

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key {  get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }


    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
