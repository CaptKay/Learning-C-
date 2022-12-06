using System;

class Pet
{
  public string species;
  public string type;
  public string name;
  public string color;

  public Pet(string petSpecies, string petType, string petName, string petColor)
  {
    this.species = petSpecies;
    this.type = petType;
    this.name = petName;
    this.color = petColor;
  }
}