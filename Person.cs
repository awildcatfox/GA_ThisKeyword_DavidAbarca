using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_DavidAbarca
{
    internal class Person
    {
        // Fields
        private string name;
        private int age;

        // Constructor that uses 'this' to distinguish fields from parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display the person's details
        public void Display()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        public Person(string name) : this(name, 0) // Calls the main constructor
        {
        }

        // Method to update the person's age
        public void SetAge(int age)
        {
            this.age = age; // 'this' clarifies that we're assigning to the instance field
        }
    }
}
