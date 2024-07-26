using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
}