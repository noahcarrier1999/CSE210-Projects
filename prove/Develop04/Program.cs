using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");


    }
}

public class Vehicle {
    protected string _make;
    protected string _model;
    protected int _miles;

    public Vehicle(string make, string model, int miles){
        _make = make;
        _model = model;
        _miles = miles;
    }
}

class Car: Vehicle{
    public Car(string make, string model, int miles) : base(make, model, miles){

    }

}

class Truck: Vehicle{
    private int _towing;

    public Truck(string make, string model, int miles, int towing) : base(make,model,miles){
        _towing = towing;
    }

}



public class Shape{
    private string _color;

    public Shape(string color){
        _color = color;
    }
}

public class Circle:Shape{
    private float _radius;

    public Circle(string color, float radius) :base(color){
        _radius = radius;
    }
}

public class Square:Shape{
    private float _sideLength;

    public Square(string color, float sideLength) :base(color){
        _sideLength = sideLength;
    }
}