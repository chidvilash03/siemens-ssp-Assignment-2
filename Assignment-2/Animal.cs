using System;


namespace AnimalClass
{
    //animal class
    class Animal
    {
        //method to make sound
        public virtual void  MakeSound()
        {
            Console.WriteLine("Animal is making Sound");
        }

        //mothod to make move
        public virtual void  Move()
        {
            Console.WriteLine("Animal is start moving");
        }
    }
    //lion class inherits from animal class
    class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Lion is Roaring...");
        }

        public override void Move()
        {
            Console.WriteLine("Lion is Start Moving...");
        }
    }
    //fish class inherits from animal class
    class Fish : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Fish is Making Sound...");
        }

        public override void Move()
        {
            Console.WriteLine("Fish is start Moving...");
        }
    }
}
