using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_arv
{
    class Dog : Animal
    {
        bool _eatenHomeWork { get; set; }
          
        //2 constructors 1 where we can manually set all values, the other one comes we use the empty animal constructor
        // and set predefined values so you can create a "default" dog
        //for every subclass we add another property
        public Dog(bool eatenHomework, int age, bool likesHuman, string name,  string colour)
            : base(age, likesHuman, name, colour)
        {
            _eatenHomeWork = eatenHomework;
            _species = "dog";
           
        }
        public Dog ()
        {
            _age = 5;
            _name = "doggi";
            _likeshuman = true;
            _species = "dog";
            _colour = "black";
        }

        //setting upp all the methods for different types of dog where we override 3 methods from main
        //also creating a fourth that we later override for subclasses of dog
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} is barking like a {_species}");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping, ZZzzzZZ");
        }
        public override void eat()
        {
            Console.WriteLine($"{_name} eats some dog food, nomnom");
        }

        public virtual void Fetch()
        {
            Console.WriteLine($"{_name} springer apport!");
        }

    }

    // we never ask for manual input for property: _species since we already know it when creating class
    class Labrador : Dog
    {
        public bool _smart;
       public Labrador (bool smart, bool eatenHomework, int age, bool likesHuman, string name, string colour)
     : base(eatenHomework, age, likesHuman, name,  colour)
        {
            _smart = smart;
            _species = "labrador";
        }
        
        //Constructor for "default" labrador
        public Labrador () : base()
        {
            _smart = true;
            _species = "labrador";
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} is barking like a {_species}");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping, ZZzzzZZ");
        }
        public override void eat()
        {
            Console.WriteLine($"{_name} eats some dog food, nomnom");
        }

       //create a simpel method that gives 2 outputs depending on a property of labrador class but we also carry over 
       // base methods since all dogs fetch but the outcome will be different
        public override void Fetch()
        {
            base.Fetch();
            if (_smart = true)
                Console.WriteLine($"{_name} hittade pinnen direkt! vilken smart hund");
            else
                Console.WriteLine($"{_name} det gick inte fort att hitta pinnen! tror {_name} är lite långsam :(");
        }
    }

    //instead of a bool we use a integer for the unique property of chihuahua
    class Chihuahua : Dog
    {
        public int _weight { get; set; }

        public Chihuahua (int weight, bool eatenHomework, int age, bool likesHuman, string name, string species, string colour) 
            : base (eatenHomework, age, likesHuman, name, colour)

        {
            _weight = weight;
            _species = "Chihuahua";
        }
       
        //constructor for default chihuahua
        public Chihuahua() : base ()
        {
            _weight = 1;
            _species = "chihuahua";
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_name} is barking like a small chihuahua, annoying");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping, ZZzzzZZ");
        }
        public override void eat()
        {
            Console.WriteLine($"{_name} eats a little dog food, nomnom");
        }

        //method checks a property then writes to console depending on value of 1 of the properties.
        public override void Fetch()
        {
            base.Fetch();
            if (_weight < 3)
                Console.WriteLine($"{_name} hittade pinnen direkt, men den var så pass liten att {_name} inte kunde lyfta pinnen :(");
            else
                Console.WriteLine($"{_name} hittade pinnen och kom tillbaka med den!");
        }

    }
}
