namespace GA_ThisKeyword_DavidAbarca
{// David Abarca
    // 2/14/24
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person1 = new Person("Alice", 25);
            person1.Display(); // Outputs: Name: Alice, Age: 25

            Person person2 = new Person("Bob");
            person2.Display(); // Outputs: Name: Bob, Age: 0
            person2.SetAge(30);
            person2.Display(); // Outputs: Name: Bob, Age: 30
            Person person3 = new Person("Dereck");
            person3.SetAge(27); //uses set age method which uses this.age to be able to manually
                                //set age in main
            person3.Display(); // uses the person constructor to this.name and this.age
        }
    }
}