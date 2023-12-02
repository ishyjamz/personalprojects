using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly DataContext _context;
    
    public PokemonRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Pokemon> GetPokemon()
    {
        return _context.Pokemon.OrderBy(p => p.Id).ToList();
    }

    public Pokemon GetPokemonById(int id)
    {
        var pokemon = _context.Pokemon.FirstOrDefault(p => p.Id == id);

        if (pokemon == null)
        {
            return null;
        }

        return pokemon;
    }

    public Pokemon GetPokemonByName(string name)
    {
        var pokemon = _context.Pokemon.FirstOrDefault(p => p.Name == name);

        if (pokemon == null)
        {
            return null;
        }

        return pokemon;

    }
    
    public bool PokemonExists(int id)
    {
        return _context.Pokemon.Any(p => p.Id == id);
    }

    public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
    {
        var pokemonOwnerEntity = _context.Owners
            .FirstOrDefault(o => o.Id == ownerId);
        var categoryEntity = _context.Categories
            .FirstOrDefault(c => c.Id == categoryId);

        PokemonOwner pokemonOwner = new ()
        {
            Owner = pokemonOwnerEntity,
            Pokemon = pokemon
        };

        PokemonCategory pokemonCategory = new()
        {
            Category = categoryEntity,
            Pokemon = pokemon
        };
        
        _context.Add(pokemon);
        _context.Add(pokemonCategory);
        _context.Add(pokemonOwner);
        
        return this.Save();
    }

    public bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon)
    {
        _context.Update(pokemon);
        return Save();
    }

    public bool Save()
    {
        var save = _context.SaveChanges();
        return save > 0 ? true : false;
    }
} 