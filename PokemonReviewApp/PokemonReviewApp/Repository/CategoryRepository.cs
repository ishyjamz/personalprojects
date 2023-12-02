using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context;
    
    public CategoryRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Category> GetCategories()
    {
        return _context.Categories.OrderBy(c => c.Id).ToList();
    }

    public Category GetCategory(int id)
    {
        return _context.Categories.FirstOrDefault(c => c.Id == id);
    }

    public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
    {
        var pokemonList = _context.PokemonCategories
            .Where(pc => pc.CategoryId == categoryId)
            .Select(pc => pc.Pokemon)
            .ToList();

        return pokemonList;
    }

    public bool CategoryExists(int id)
    {
        return _context.Categories.Any(c => c.Id == id);
    }

    public bool CreateCategory(Category category)
    {
        _context.Add(category);

        return this.Save();
    }
    
    public bool UpdateCategory(Category category)
    {
        _context.Update(category);
        return this.Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}