using BattlePokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    internal class Alakazam : Pokemon
    {
        public Alakazam() 
        {
            this.name = "Alakazam";
            Random random= new Random();
            this.HP = random.Next(220,314);
            this._image = Properties.Resources._065;
            this.attack = random.Next(90, 165);
            this.defense = random.Next(57, 160);
        }
    }
}
