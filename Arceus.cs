using BattlePokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    internal class Arceus : Pokemon
    {
        public Arceus() 
        {
            this.name = "Arceus";
            Random random= new Random();
            this.HP = random.Next(266,360);
            this._image = Properties.Resources._493;
            this.attack = random.Next(84, 185);
            this.defense = random.Next(92, 196);
        }
    }
}
