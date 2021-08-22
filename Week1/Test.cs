using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    class Test
    {
    static void Main(string[] args)
        {
            Student student1 = new Student("Emma", 20);
            Teacher teacher1 = new Teacher("Joel", 28);
            Console.WriteLine("The student name is " + student1.name + " and he/she is " + student1.age);
            Console.WriteLine("The teacher name is " + teacher1.name + " and he/she is " + teacher1.age);
        }
    }

    class Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Teacher
    {
        public string name;
        public int age;

        public Teacher(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
