using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : Controller
{
    private readonly IPokemonRepository _pokemonRepository;
    private readonly IMapper _mapper;

    public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
    {
        _pokemonRepository = pokemonRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetPokemons()
    {
        var pokemons = _pokemonRepository.GetPokemons();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var pokemonsDto = _mapper.Map<ICollection<PokemonDto>>(pokemons);
        return Ok(pokemons);
    }

    [HttpGet("{pokeId}")]
    public IActionResult GetPokemon(int pokeId)
    {
        if (!_pokemonRepository.PokemonExists(pokeId))
            return NotFound();
        var pokemon = _pokemonRepository.GetPokemon(pokeId);
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var pokemonDto = _mapper.Map<PokemonDto>(pokemon);
        return Ok(pokemonDto);
    }

    [HttpGet("{pokeId}/rating")]
    public IActionResult GetPokemonRaing(int pokeId)
    {
        if (!_pokemonRepository.PokemonExists(pokeId))
            return NotFound();
        var rating = _pokemonRepository.GetPokemonRating(pokeId);
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        return Ok(rating);
    }
}