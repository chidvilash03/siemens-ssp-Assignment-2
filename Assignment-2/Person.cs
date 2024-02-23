using System;

namespace SchoolSytemClass
{
    //base class person
    class Person
    {
        //properties
        public string name;
        public int age;

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    //student class inherits from person class
    class Student : Person
    {
        //additional property
        public int grade;

        //constructor
        public Student(string name, int age, int grade) : base(name, age)
        {
            this.grade = grade;
        }

        //method to display student info
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name: {0}, Age: {1}, Grade: {2}", name, age, grade);
        }
    }

    //teacher class inherits from person class
    class Teacher : Person
    {
        //additional property
        public string subjectsTaught;

        //constructor
        public Teacher(string name, int age, string subjectsTaught) : base(name, age)
        {
            this.subjectsTaught = subjectsTaught;
        }

        //method to display teacher info
        public void DisplayTeacherInfo()
        {
            Console.WriteLine("Teacher Name: {0}, Age: {1}", name, age);
            Console.WriteLine("Subjects Taught: " + subjectsTaught);

        }
    }
}
