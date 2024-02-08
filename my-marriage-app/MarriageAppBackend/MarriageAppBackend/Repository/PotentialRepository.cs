using MarriageAppBackend.Data;
using MarriageAppBackend.Models;

namespace MarriageAppBackend.Repository;

public class PotentialRepository
{
  private readonly DataContext _context;

  public PotentialRepository(DataContext context)
  {
    _context = context;
  }

  public ICollection<Potential> GetPotentials()
  {
    return _context.Potentials.OrderBy(p => p.Id).ToList();
  }

  public Potential? GetPotentialById(int id)
  {
    var potential = _context.Potentials.FirstOrDefault(p => p.Id == id);

    return potential;
  }
}
