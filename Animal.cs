using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_arv
{
    
    //Top class called Animal made it Abstract since we are not making any animals directly only subclasses of Animal
    abstract class Animal
    {
        public int _age { get; set; }
        public bool _likeshuman { get; set; }
        public string _name { get; set; }
        public string _species { get; set; }
        public string _colour { get; set; }
    
        
        //1 empty constructor and 1 where we set the properties just so you can
        public Animal ()
        {

        }
        
        public Animal (int age, bool likesHuman, string name,  string colour)
        {
            _age = age;
            _likeshuman =likesHuman;
            _name = name;
            _colour = colour;
        }

        //the three methods that are shared by all subclasses
        public abstract void MakeSound();
        public abstract void Sleep();
        public abstract void eat ();

        
        

    }

}
