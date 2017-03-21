using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class FireTypePokemon : Pokemon
    {
        public int FireTypePowerUpCandy { get; set; }

        public int FireTypePowerUpStarDust { get; set; }

        public FireTypePokemon(
            string name,
            int nationalNo,
            string[] type,
            float height,
            float weight
        )
            : base(
                   name,
                   nationalNo,
                   type,
                   height,
                   weight
                  )
        {
            this.PowerUpCandy[this.Name] = 3;
            this.PowerUpStardust[this.Name] = 3000;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("使用火系大絕");
        }
    }
}