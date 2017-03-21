using PokemonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = PokemonFactory.;
            Pokemon pokemon2 = new Ivysaur();
            pokemon1.Attack(pokemon2);
        }
    }
}