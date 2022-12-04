using System;


class Program
{

    static void Main(string[] args)
    {
      Car salonCar = new Car();
      salonCar.make = "Audi";
      salonCar.model = "A4";
      salonCar.year = 2014;
      salonCar.color = "Black";
      int maxSpeed0 = salonCar.maxSpeed(220);
      //salonCar.fullThrottle();

      Car suvCar = new Car();
      suvCar.make = "Volvo";
      suvCar.model = "CX90";
      suvCar.year = 2022;
      suvCar.color = "Grey";
      int maxSpeed = suvCar.maxSpeed(240);
      //suvCar.fullThrottle();


      Console.WriteLine($"I love SUVs such as {suvCar.make} {suvCar.model} {suvCar.year} model,\nmost especially the {suvCar.color} color. Which has maximiun speed of {maxSpeed} and "); suvCar.fullThrottle();

      Console.WriteLine($"I love salon cars such as {salonCar.make} {salonCar.model} {salonCar.year} model,\nmost especially the {salonCar.color} color. Which has maximiun speed of {maxSpeed0} and "); salonCar.fullThrottle();
        

      
      /*Fruit myFruit = new Fruit();
      Console.WriteLine(myFruit.name("Apple"));




      Person myPerson = new Person();
      Console.WriteLine(myPerson.name);*/
    }
      

}

