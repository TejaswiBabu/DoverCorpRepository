using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    abstract class OpenUniversity
    {
        public void Courses()
        {
            Console.WriteLine("Courses are assigned by the university");
        }
        public void Exams()
        {
            Console.WriteLine("Exams conducted by universty");
        }
        public abstract void Enrollments();
        public abstract void Training();
    }
    class StudyCenter:OpenUniversity 

    {
        public override void Enrollments()
        {
            Console.WriteLine("Advertisement and enrollments at study center");
        }
        public override void Training()
        {
            Console.WriteLine("Training at study center");
        }


    }
    class Program44
    {

    }
}
/*An abstract class is a partially implemented class.
An abstract class is a class contains both abstract (unimplemented) methods and concrete (implemented) methods, Abstract classes cannot be instantiated.
Why do we need?
It is used in the scenarios like part of the implementation to be done in derived (child) class.
Points to note:
    Abstract class contains abstract methods and concrete methods.
    An abstract class may or may not contain abstract method.
    An abstract class may or may not contain concrete method.
    Any class want to treat must inherit should be abstract (Abstract class must inherit)
    Abstract method should be in public modifier.
What is an abstract method?
This is an unimplemented method, Abstract methods must override in child class.
What are concrete methods?
Concreted methods are the methods which are implemented (also called as non abstract methods).
These are the implemented methods in abstract class.
Real time example:
Array is an abstract class*/