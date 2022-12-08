using System;

class Car
{
    private string make;
    private string model;
    private string color;   //this is a variable and they are called Fields in class
    private int year;
//Getters and Setters
  public string Make
  { get; set; }
    
public string Model
  { get; set; }

  public string Color
  { get; set; }

  public int Year
  { get; set; }
/*
    //Constructor
    public Car(string carMake, string carModel, string carColor, int carYear)
    {
      this.make = carMake;
      this.model = carModel;
      this.color = carColor;
      this.year = carYear;
    }*/
}