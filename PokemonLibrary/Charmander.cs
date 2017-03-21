using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    internal class Charmander : FireTypePokemon
    {
        public Charmander()
            : base(
                  "小火龍",
                  2,
                  new string[] { "Fire" },
                  0.71f,
                  6.9f
                 )
        { }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("火龍光束");
        }
    }
}