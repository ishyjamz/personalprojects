using MarriageAppBackend.Data;
using MarriageAppBackend.Models;

namespace MarriageAppBackend;

public class DataSeed
{
  private readonly DataContext _dataContext;

  public DataSeed(DataContext context)
  {
    this._dataContext = context;
  }

  public void SeedDataContext()
  {
    if (!_dataContext.Potentials.Any())
    {
      var potential1 = new Potential
      {
        Id = 1,
        FirstName = "Maryam",
        LastName = "Begum",
        Description = "I like watching sports",
        City = "London",
        Ethnicity = "Bengali",
        Height = 6.6,
        Occupation = "Nurse"
      };
      var potential2 = new Potential
      {
        Id = 2,
        FirstName = "Laila",
        LastName = "Aktar",
        Description = "I like watching anime",
        City = "Birmingham",
        Ethnicity = "Pakistani",
        Height = 5,
        Occupation = "Teacher"
      };
      var potential3 = new Potential
      {
        Id = 3,
        FirstName = "Habiba",
        LastName = "Islam",
        Description = "I like watching cooking shows",
        City = "Manchester",
        Ethnicity = "Bengali",
        Height = 4.6,
        Occupation = "Sports Analyst"
      };
      var potential4 = new Potential
      {
        Id = 4,
        FirstName = "Rose",
        LastName = "Ahmad",
        Description = "Very affectionate",
        City = "Colchester",
        Ethnicity = "Ethiopian",
        Height = 5.6,
        Occupation = "Doctor"
      };
      _dataContext.Potentials.AddRange(potential1, potential2, potential3, potential4);
      _dataContext.SaveChanges();
    }
  }
}
