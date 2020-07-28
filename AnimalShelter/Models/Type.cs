using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
  public class Type
  {
    public int TypeId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Breed { get; set; }
    public int Date { get; set; }

  }
}