using AutoMapper;
using MarriageAppBackend.Dtos;
using MarriageAppBackend.Models;

namespace MarriageAppBackend.Helper;

public class MappingProfiles : Profile
{
  public MappingProfiles()
  {
    CreateMap<Potential, PotentialDto>();
  }
}
