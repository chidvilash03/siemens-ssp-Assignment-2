using System;

namespace ShapeClass 
{
    //shape class
    class Shape
    {
        public virtual void calculateArea() { }
    }


    //Rectangle class inherits from shape
    class Rectangle : Shape
    {
        double length;
        double breadth;
        //constructor
        public Rectangle(double length,double breadth) 
        { 
            this.length = length;
            this.breadth = breadth;
        }
        //method to calculate area of the rectangle
        public override void calculateArea()
        {
            double area = length * breadth;
            Console.WriteLine("The area of Rectangle is : " + area);
        }
    }

    //circle class inherits from shape
    class Circle : Shape
    {
        double radius;
        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //method to calculate area of the circle
        public override void calculateArea()
        {
            double area = 3.14 *radius * radius;
            Console.WriteLine("The area of Circle is : "+ area);
        }
    }
    
}
