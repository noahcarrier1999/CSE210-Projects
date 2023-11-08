using System;


class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square("red", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("blue", 10, 50);
        shapes.Add(rectangle1);

        Circle circle1 =  new Circle("purple", 32);
        shapes.Add(circle1);

        foreach (Shape s in shapes){
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"the {color} shape has an Area of {area}");


        }


        // System.Console.WriteLine(square1.GetColor());
        // System.Console.WriteLine(square1.GetArea());


    }
}

// public class Vehicle {
//     protected string _make;
//     protected string _model;
//     protected int _miles;

//     public Vehicle(string make, string model, int miles){
//         _make = make;
//         _model = model;
//         _miles = miles;
//     }
// }

// class Car: Vehicle{
//     public Car(string make, string model, int miles) : base(make, model, miles){

//     }

// }

// class Truck: Vehicle{
//     private int _towing;

//     public Truck(string make, string model, int miles, int towing) : base(make,model,miles){
//         _towing = towing;
//     }

// }



// public class Shape{
//     private string _color;

//     public Shape(string color){
//         _color = color;
//     }
// }

// public class Circle:Shape{
//     private float _radius;

//     public Circle(string color, float radius) :base(color){
//         _radius = radius;
//     }
// }

// public class Square:Shape{
//     private float _sideLength;

//     public Square(string color, float sideLength) :base(color){
//         _sideLength = sideLength;
//     }
// }