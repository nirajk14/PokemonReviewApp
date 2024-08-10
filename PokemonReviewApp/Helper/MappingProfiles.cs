using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pokemon, PokemonDto>();
        CreateMap<Category,CategoryDto>();
        CreateMap<Country, CountryDto>();
        CreateMap<Owner, OwnerDto>();
        CreateMap<Reviewer, ReviewerDto>();
        CreateMap<Review, ReviewDto>();
        CreateMap<PokemonDto, Pokemon>();
        CreateMap<CategoryDto,Category>();
        CreateMap<CountryDto, Country>();
        CreateMap<OwnerDto, Owner>();
        CreateMap<ReviewerDto, Reviewer>();
        CreateMap<ReviewDto, Review>();
    }
}