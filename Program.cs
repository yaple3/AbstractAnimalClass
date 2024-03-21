using System;

namespace AbstractAnimalClass
    {
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Dog : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
            public string Coat { get; set; }

            public Dog()
            {
                Name = string.Empty;
                Type = string.Empty;
                Age = 0;
                Coat = string.Empty;
            }
            public Dog(string name, string type, int age, string coat)
            {
                Name = name;
                Type = type;
                Age = age;
                Coat = coat;
            }

            // override the abstract method 
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name + "\nI'm " + Age + "\nMy coat is " + Coat;
            }
        }//end of Dog class
        static void Main(string[] args)
        {
            // Create Dog object using default constructor
            Dog buster = new Dog();
            buster.Name = "Buster";
            buster.Type = "Boxer";
            buster.Age = 4;
            buster.Coat = "Smooth";

            //create Dog object using paramaterized constructor
            Dog sparky = new Dog("Sparky", "Doodle", 2, "Curly");

            //Display methods
            Console.WriteLine(buster.whatAmI());
            Console.WriteLine(buster.Describe());
            Console.WriteLine();
            Console.WriteLine(sparky.whatAmI());
            Console.WriteLine(sparky.Describe());


        }  //end of Main method  
    }//end of Program class
}//end of AbstractAnimalClass namespace
