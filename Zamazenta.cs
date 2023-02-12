using BattlePokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    internal class Zamazenta : Pokemon
    {
        public Zamazenta() 
        {
            this.name = "Zamazenta";
            Random random= new Random();
            this.HP = random.Next(294,388);
            this._image = Properties.Resources._889;
            this.attack = random.Next(85, 154);
            this.defense = random.Next(87, 175);
        }
    }
}
