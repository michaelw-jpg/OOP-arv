using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_arv
{
    class Bear : Animal
    {

        public bool _fat;
        public Bear(string species ,bool fat,int age, bool likesHuman, string name, string colour) : base(age, likesHuman, name, colour)
        {
            _fat = fat;
            _species = species;
        }

        public Bear () : base()
        {
            _likeshuman = false;
            _colour = "brown";
            _age = 12;
            _name = "Winnie";
            _species = "brown bear";
            _fat = false;
        }

        public override void eat()
        {
            Console.WriteLine("Björnen äter mycket så att han kan gå i ide");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Björnen vrålar som en {_species}");
        }

        public override void Sleep()
        {
            Console.WriteLine("Björnen sover i sin grotta");
        }

        
        //unique method for bear checks unique bear property
        public void Fishing()
        {
            if (_fat = false)
            Console.WriteLine($"Björnen fiskar , men de går inte bra för att {_name} sjunker");

            else
            Console.WriteLine($"Björnen fiskar och det går dunder för att han är så pass tjock och flyter");
        }
    }
}
