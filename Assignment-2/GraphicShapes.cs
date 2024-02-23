using System;


namespace GraphicShapesClass 
{
    //base class graphic shapes
    class GraphicShapes
    {
        //properties
        public int x;
        public int y;

        //constructor
        public GraphicShapes(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }

        //method to draw the shape
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape at ({0},{1})", x, y);
        }
    }

    //circle class inherits from shapes
    class GraphicCircle : GraphicShapes
    {
        //additional property
        public double radius;

        //constructor
        public GraphicCircle(int x, int y, double radius) : base(x, y)
        {
            this.radius = radius;
        }
        //method to override draw
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle shape at ({0},{1}) with radius {2} ", x, y, radius);
        }
    }

    //class square that inherits from Graphic shapes
    class GraphicSquare : GraphicShapes
    {
        //additional property
        public double side;

        //constructor
        public GraphicSquare(int x, int y, double side) : base(x, y)
        {
            this.side = side;
        }
        //method to override draw
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square shape at ({0},{1}) with side length {2} ", x, y, side);
        }
    }
}
