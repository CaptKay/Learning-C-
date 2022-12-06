using System;


class Car
{
    public string make;
    public string model;
    public string color;   //this is a variable and they are called Fields in class
    public int year;


    //Constructor
    public Car(string carMake, string carModel, string carColor, int carYear)
    {
      this.make = carMake;
      this.model = carModel;
      this.color = carColor;
      this.year = carYear;
    }
}