using System;
using ShapeClass;
using AnimalClass;
using EmployeeClass;
using ProductClass;
using VehicleClass;
using GraphicShapesClass;
using AccountClass;
using SchoolSytemClass;

namespace ProgramClass
{


    class Program
    {
        //method to execute exercise1 problem
        public void CreateShapeObjects()
        {
            //Taking length and breadth as input 
            Console.WriteLine("Enter the length of the Rectangle : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the Rectangle : ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            //Creating rectangle object
            Rectangle rectangle = new Rectangle(length, breadth);
            //calculating rectangle area
            rectangle.calculateArea();

            //taking radius of the circle as input
            Console.WriteLine("Enter the radius of the Circle : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            //calculating circle area;
            circle.calculateArea();

        }

        //method to execute exercise 2 problem
        public void CreateAnimalObjects()
        {
            //create lion object
            Lion lion = new Lion();
            //method to make sound
            lion.MakeSound();
            //method to make move
            lion.Move();

            //create fish object
            Fish fish = new Fish();
            //method to make sound
            fish.MakeSound();
            //method to make move
            fish.Move();
        }

        //method to execute exercise 3 problem
        public void CreateEmployeeObjects()
        {
            //taking properties as input
            Console.WriteLine("Enter the name : ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter the employee id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary : ");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the department : ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter the programming Language");
            string programmingLanguage = Console.ReadLine();

            Console.WriteLine("ENTER 1 FOR CALCULATING BONUS FOR MANAGER AND 2 FOR CALCULATING BONUS FOR DEVELOPER :");
            int choice = Convert.ToInt32(Console.ReadLine());
            //choices for calculating bonus for manager and developer
           if(choice== 1)
            {
                //creating objects
                Manager manager = new Manager(employeeName, id, employeeSalary, dept);
                manager.CalculateBonus();
            }
            else
            {
                //creating objects
                Developer dev = new Developer(employeeName, id, employeeSalary, programmingLanguage);
                dev.CalculateBonus();
            }

        }

        //method to execute exercise 4 problem
        public void CreateProductObjects()
        {
            //taking properties as input
            Console.WriteLine("Enter the name of the product : ");
            string name  = Console.ReadLine();
            Console.WriteLine("Enter the product id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the product : ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER 1 FOR CALCULATING SHIPPING COST FOR PHYSICAL PRODUCTS AND 2 FOR DISPLAYING LINK  FOR DIGITAL PRODUCTS :");
            int choice = Convert.ToInt32(Console.ReadLine());
            //choices for calculating shipping cost and displaying download link
            if (choice == 1)
            {
                //creating objects
                PhysicalProduct item = new PhysicalProduct(id,name, productPrice);
                item.CalculateShippingCost();
            }
            else
            {
                //creating objects
                DigitalProduct product = new DigitalProduct(id,name, productPrice);
                product.DisplayDownloadLink();
            }
        }

        //method to execute exercise 5 problem
        public void CreateVehicleObjects()
        {
            //taking properties as input
            Console.WriteLine("Enter the Make : ");
            string make = Console.ReadLine();
            Console.WriteLine("Enter the model : ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the color : ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter the cost : ");
            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER 1 FOR DISPLAYING CAR CLASS AND 2 FOR DISPLAYING MOTORCYCLE CLASS");
            int choice = Convert.ToInt32(Console.ReadLine());
;            //choices for calculating bonus for manager and developer
            if (choice == 1)
            {
                //creating objects
               Car car = new Car(make , model, year,cost);
                car.Display();
            }
            else
            {
                //creating objects
                Motorcycle bike = new Motorcycle(make, model, year, color);
                bike.Display();
            }
        }

        //method to execute exercise 6 problem
        public void CreateGraphicShapeObjects()
        {
            Console.WriteLine("Enter the x coordinate : ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate : ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER 1 FOR CIRCLE AND 2 FOR SQUARE  : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the radius of the circle : ");
                double rad = Convert.ToDouble(Console.ReadLine());
                GraphicCircle circle = new GraphicCircle(X, Y,rad);
                circle.Draw();

            }
            else
            {
                Console.WriteLine("Enter the side of the square : ");
                double len = Convert.ToDouble(Console.ReadLine());
                GraphicSquare square = new GraphicSquare(X, Y, len);
                square.Draw();

            }
        }

        //method to execute exercise 7 problem

        public void CreateAccountObjects()
        {
            Console.WriteLine("Enter the name of the holder : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the account number :");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the balance : ");
            double bal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the interest rate : ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(number,name, bal,interestRate);
            account.CalculateInterest();
        }

        //method to execute exercise 8 problem

        public void CreatePersonObjects()
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            int age  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER 1 FOR Teacher AND 2 FOR Student  : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the Subjects Taught : ");
                string subjects = Console.ReadLine();
                Teacher teacher = new Teacher(name, age,subjects);
                teacher.DisplayTeacherInfo();
            }
            else
            {
                Console.WriteLine("Enter the Grade for the student : ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(name, age, grade);
                student.DisplayStudentInfo();
            }


        }


        static void Main()
        {
            //To run the exercise1 problem uncomment the below lines
            //Program exercise1 = new Program();
            //exercise1.CreateShapeObjects();

            //To run the exercise2 problem uncomment the below lines
            //Program exercise2 = new Program();
            //exercise2.CreateAnimalObjects();

            //To run the exercise3 problem uncomment the below lines
            //Program exercise3 = new Program();
            //exercise3.CreateEmployeeObjects();

            //To run the exercise 4 problem uncomment the below lines
            //Program exercise4 = new Program();
            //exercise4.CreateProductObjects();

            //To run the exercise 5 problem uncomment the below lines
            //Program exercise5 = new Program();
            //exercise5.CreateVehicleObjects();

            //To run the exercise 6 problem uncomment the below lines
            //Program exercise6 = new Program();
            //exercise6.CreateGraphicShapeObjects(); 

            //To run the exercise 7 problem uncomment the below lines
            //Program exercise7 = new Program();
            //exercise7.CreateAccountObjects();

            //To run the exercise 8 problem uncomment the below lines
            //Program exercise8 = new Program();
            //exercise8.CreatePersonObjects();



        }
    }
}



