using BattlePokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    internal class Snorlax : Pokemon
    {
        public Snorlax() 
        {
            this.name = "Snorlax";
            Random random = new Random();
            this.HP = random.Next(430,524);
            this._image = Properties.Resources._143;
            this.attack = random.Next(78, 154);
            this.defense = random.Next(90, 175);
        }
        
    }
}
