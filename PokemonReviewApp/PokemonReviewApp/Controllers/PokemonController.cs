using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PokemonReviewApp.Dtos;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
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
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemon()
    {
        var pokemonList = _mapper.Map<List<PokemonDto>>(_pokemonRepository.GetPokemon());

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(pokemonList);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Pokemon))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonById(int id)
    {
        if (!_pokemonRepository.PokemonExists(id))
            return NotFound();
        
        var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemonById(id));

        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        return Ok(pokemon);
    }

    [HttpPost]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public IActionResult CreatePokemon( [FromQuery] int ownerId, 
        [FromQuery] int categoryId, [FromBody] PokemonDto pokemonDto)
    {
        if (pokemonDto == null)
        {
            return BadRequest(ModelState);
        }
        
        var pokemon = _pokemonRepository.GetPokemon()
            .FirstOrDefault(p => p.Name.Trim().ToLower()
                                 == pokemonDto.Name.TrimEnd().ToLower());
        
        if (pokemon != null)
        {
            ModelState.AddModelError("", "Pokemon with the name " 
                                         + pokemonDto.Name + " already exists");
            return StatusCode(422, ModelState);
        }
        
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        var pokemonMap = _mapper.Map<Pokemon>(pokemonDto);

        if (!_pokemonRepository.CreatePokemon(ownerId, categoryId, pokemonMap))
        {
            ModelState.AddModelError("", "Did not save broski");
            return StatusCode(422, ModelState);
        }

        return Ok("Successfully added pokemon named: " + pokemonMap.Name);
    }

    [HttpPut("{pokemonId}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public IActionResult UpdatePokemon(int pokemonId, [FromQuery] int ownerId, 
        [FromQuery] int categoryId, PokemonDto pokemonDto)
    {
        if (pokemonDto == null)
            return BadRequest(ModelState);

        if (pokemonId != pokemonDto.Id)
            return BadRequest(ModelState);

        if (!_pokemonRepository.PokemonExists(pokemonId))
            return NotFound();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var pokeMap = _mapper.Map<Pokemon>(pokemonDto);

        if (!_pokemonRepository.UpdatePokemon(ownerId, categoryId, pokeMap))
        {
            ModelState.AddModelError("", "Problem Saving...");
            return StatusCode(500, ModelState);
        }

        return Ok("Very nice pokemon updated");
    }
    
}