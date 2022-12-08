using System;


//Parent Class
class Vehicle{
  public string name = "Benz";
  public void honk(){//this honk is for the parent class
    Console.WriteLine("IK!!!!!, Tuut, TuuuuuuuuuuuuuuT!");
  }
}



//Child Class
class MotorCar : Vehicle{
  public string modelName(string x){
    return x;
  }
}