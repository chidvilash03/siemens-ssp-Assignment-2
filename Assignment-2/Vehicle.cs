using System;


namespace VehicleClass
{
    //base class vehicle
    class Vehicle
    {
        //properties
        public string make;
        public string model;
        public int year;

        //constructor
        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        //method to display information
        public virtual void Display()
        {
            Console.WriteLine("This is Car");
            Console.WriteLine("Make : " + make);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Year : " + year);
        }
    }
    //car class inherits from vehicle
    class Car : Vehicle
    {
        //additional property
        public double cost;

        //constructor
        public Car(string make,string model,int year,double cost) : base(make, model, year)
        {
            this.cost = cost;
        }

        //override method to display information of the car
        public override void Display()
        {
            Console.WriteLine("This is Car");
            Console.WriteLine("Make : " + make);
            Console.WriteLine("Model : "+ model);
            Console.WriteLine("Year : " + year);
            Console.WriteLine("Cost : " + cost);
        }
    }

    //motorcycle class inherits from vehicle class
    class Motorcycle : Vehicle
    {
        //additional property
        public string color;

        //constructor
        public Motorcycle(string make,string model,int year,string color) : base(make, model, year)
        {
            this.color = color;
        }

        //method to override display the information of motorcycle
        public override void Display()
        {
            Console.WriteLine("This is Motorcycle");
            Console.WriteLine("Make : " + make);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Year : " + year);
            Console.WriteLine("Color : " + color);

        }
    }
}



