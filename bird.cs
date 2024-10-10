using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_arv
{
    class Bird : Animal
    {
        public bool _hasWings { get; set; }

        public Bird () : base()
        {
            _colour = "black";
            _name = "steffe";
            _likeshuman = false;
            _age = 3;
            _hasWings = true;
            _species = "bird";
        }

        // we ask for species since there are many different types of birds
        public Bird(string species,bool hasWings, int age, bool likesHuman, string name, string colour) 
            : base (age, likesHuman, name, colour)
        {
            _hasWings = hasWings;
            _species = species;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fågeln kvittrar, tweet, tweet");
        }

        public override void Sleep()
        {
            Console.WriteLine("fågeln sover på sin pinne");
        }

        public override void eat()
        {
            Console.WriteLine("fågeln äter sina fågelfrön");
        }

        //unique method for bird class
        public void Fly()
        {
            if (_hasWings = true)
            Console.WriteLine($"{_name} flyger jättehögt och snabbt");

            else
            Console.WriteLine($"{_name} kan inte flyga fast det är en fågel, very sadge");
        }


    }
}
