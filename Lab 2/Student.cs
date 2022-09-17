using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public string Commentary()
        {
            if (Grade <= 3) return "Bad Student";
            else if (Grade <= 5) return "Average Student";
            else return "Excellent Student";
        }

        public void showStudent()
        {
            Console.WriteLine($"{Name} is {Age} years old. {Commentary()}");
        }
    }
}
