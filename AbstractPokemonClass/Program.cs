using System;
using System.Xml.Linq;

namespace Pokemons
{
    abstract class Pokemon
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an Pokemon";
        }
    }

    class Program
    {
        class Poke : Pokemon
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }

            public Poke()
            {
                Name = string.Empty;
                Type = string.Empty;
            }
            public Poke(string name, string type)
            {
                Name = name;
                Type = type;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name;
            }

        }
        static void Main(string[] args)
        {
           
            Poke mon = new Poke();
            mon.Name = "Bulbasaur";
            mon.Type = "Grass";
            Console.WriteLine(mon.whatAmI());
            Console.WriteLine(mon.Describe());
        }
    }
}