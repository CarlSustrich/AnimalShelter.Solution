using System;
using System.Collections.Generic;
namespace AnimalShelter.Models;

public class Animal
{
  public int AnimalId {get;set;}
  public string Name {get;set;}
  public DateTime DateOfAdmittance {get;set;}
  public string Breed {get;set;}
  public string Species {get;set;}
  public int ShelterId {get;set;}
}
