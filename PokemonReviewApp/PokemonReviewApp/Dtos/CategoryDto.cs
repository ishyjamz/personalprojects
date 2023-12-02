using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Dtos;

public class CategoryDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }
}