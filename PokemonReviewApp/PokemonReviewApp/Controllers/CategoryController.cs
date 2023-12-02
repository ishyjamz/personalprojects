using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dtos;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
    public IActionResult GetCategories()
    {
        var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());

        return Ok(categories);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(Category))]
    [ProducesResponseType(400)]
    public IActionResult GetCategory(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!_categoryRepository.CategoryExists(id))
        {
            return NotFound();
        }

        var category = _categoryRepository.GetCategory(id);

        return Ok(category);
    }

    [HttpGet("pokemon/{categoryId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonByCategory(int categoryId)
    {
        var pokemonList = _mapper.Map<List<PokemonDto>>(_categoryRepository
            .GetPokemonByCategory(categoryId));

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (pokemonList == null)
        {
            return NotFound();
        }

        return Ok(pokemonList);
    }

    [HttpPost]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public IActionResult CreateCategory([FromBody] CategoryDto categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest();
        }

        var category = _categoryRepository
            .GetCategories()
            .FirstOrDefault(c => c.Name.Trim().ToUpper() 
                                 == categoryDto.Name.TrimEnd().ToUpper());

        if (category != null)
        {
            ModelState.AddModelError("", "Category already exists");
            return StatusCode(422, ModelState);
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var categoryMap = _mapper.Map<Category>(categoryDto);

        if (!_categoryRepository.CreateCategory(categoryMap))
        {
            ModelState.AddModelError("", "Problem saving");
            return StatusCode(500, ModelState);
        }

        return Ok("Successfully added category named: " + categoryMap.Name);
    }

    [HttpPut("{categoryId}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public IActionResult UpdateCategory(int categoryId, 
        [FromBody] CategoryDto categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest(ModelState);
        }

        if (categoryId != categoryDto.Id)
        {
            return BadRequest(ModelState);
        }

        if (!_categoryRepository.CategoryExists(categoryId))
            return NotFound();

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var catMap = _mapper.Map<Category>(categoryDto);

        if (!_categoryRepository.UpdateCategory(catMap))
        {
            ModelState.AddModelError("", "Problem Saving");
            return StatusCode(500, ModelState);
        }

        return Ok("Successfully updated category name to " + categoryDto.Name);
    }
}