using System;


class Car
{
    public string make;
    public string model;
    public string color;   //this is a variable and they are called Fields in class
    public int year;
    public int maxSpeed(int x)
    {   //this is a method
        return x;
    }

    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}