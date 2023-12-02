using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemon();

    Pokemon GetPokemonById(int id);

    Pokemon GetPokemonByName(string name);
    
    bool PokemonExists(int id);

    bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

    bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
    
    bool Save();
}