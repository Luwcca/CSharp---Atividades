//utilizando o using para gerenciar e liberar o recurso no fim
// é utilizada a classe HttpClient para fazermos uma requisição http no servidor
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        //adicionado como Async pois não sabemos o tamanho da requisição
        // o await é utilizado para aguardar o comando async ser concluido
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);


        //Desrialize converte o Json em um objeto manipulavel
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        musicas[0].ExibirDetalhesDaMusica();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}