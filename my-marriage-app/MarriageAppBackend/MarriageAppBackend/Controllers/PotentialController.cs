using System.Web.Http.ModelBinding;
using AutoMapper;
using MarriageAppBackend.Dtos;
using MarriageAppBackend.Models;
using MarriageAppBackend.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelStateDictionary = Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary;

namespace MarriageAppBackend.Controllers;

[ApiController]
public class PotentialController : Controller
{
  private PotentialRepository _potentialRepository;
  private IMapper _mapper;

  public PotentialController(PotentialRepository potentialRepo, IMapper mapper)
  {
    _potentialRepository = potentialRepo;
    _mapper = mapper;
  }

  [HttpGet]
  [ProducesResponseType(200, Type = typeof(IEnumerable<Potential>))]
  public IActionResult GetPotentials()
  {
    var potentialList = _mapper.Map<List<PotentialDto>>(_potentialRepository.GetPotentials());

    if (!ModelState.IsValid)
    {
      return BadRequest(ModelState);
    }

    return Ok(potentialList);
  }
}
