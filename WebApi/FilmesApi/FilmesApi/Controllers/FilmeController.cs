using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;


[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private FilmeContext _context;
    //faz com que a controller depende do context

    private IMapper _mapper;


    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    
    //Faz o cadastro do filme
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)//cadastraremos o filme recebido por parâmetro, as informações são enviadas através do corpo da requisição 
    {

        Filme filme = _mapper.Map<Filme>(filmeDto);

        _context.Filmes.Add(filme);//add na db
        _context.SaveChanges();//salva alterações
        return CreatedAtAction(nameof(RecuperaFilmePorId),
            new { id = filme.Id },
            filme);

    }

    [HttpGet]//utiliza o IEnumerable pois é contido na lista e permite fácil manutenção
    public IEnumerable<ReadFilmeDto> RecuperaFilmes([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    //É preciso explicitar que o próprio usuário informará esses dados, por meio da consulta (query). Para tanto, usaremos a anotação [FromQuery]
    {
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take).ToList());
        //O método Skip() indica quantos elementos da lista pular
        //o Take() define quantos serão selecionados.
    }

    [HttpGet("{id}")]// executa esse metodo caso o get receba o parametro ID
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound(); //dá o erro 404 caso o filem não exista

        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);

        return Ok(filmeDto); //dá o status 200 e passa o filme
    }

    [HttpPut("{id}")]//Atualiza
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{id}")]//atualização de apenas um campo
    public IActionResult AtualizaFilmeParcial(int id, [FromBody] JsonPatchDocument<UpdateFilmeDto> patch )
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);//converte json para o modelo dto

        patch.ApplyTo(filmeParaAtualizar, ModelState);//verifica se o modelState da aplicação é valida 

        if (!TryValidateModel(filmeParaAtualizar))//valida se o modelstate está ok
        {
            return ValidationProblem(ModelState);
        }
        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id);
        if (filme == null) return NotFound();
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }

}
