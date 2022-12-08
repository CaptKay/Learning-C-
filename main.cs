using System;


class Program
{
    static void Main(string[] args)
    {

    MotorCar salon = new MotorCar();
      
      string brand = salon.name;
      string modelName = salon.modelName("C-Class");
      Console.WriteLine("My car is " + brand + " " + modelName + " " + " and it can say ");
      salon.honk();







      
      /*Car machine = new Car();
      machine.Make = "Mecedes Benz";
      machine.Model = "G-Class";
      machine.Color = "White";
      machine.Year = 2023;
      Console.WriteLine(machine.Make + " " + machine.Model + " " + machine.Color + " " + machine.Year  +  " sharp");

      Human being = new Human();
      being.Sex = "Female";
      being.Race = "Black";
      being.Place = "Nigeria";
      being.Name = "Judy";
      being.Age = 28;
      being.Height = 175;
      Console.WriteLine(being.Sex + " " + being.Race + " " + being.Place + " " + being.Name + " " + being.Age + " " + being.Height);

      Pet lope = new Pet();
      lope.Name = "Kuga";
      lope.Color = "Black";
      Console.WriteLine(lope.Color + " " + lope.Name);*/
      
    }
}