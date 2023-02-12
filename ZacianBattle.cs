using BattlePokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    internal class ZacianBattle : Pokemon
    {
        public ZacianBattle() 
        {
            this.name = "Zacian";
            Random random = new Random();
            this.HP = random.Next(294,388);
            this._image = Properties.Resources._888;
            this.attack = random.Next(85, 174);
            this.defense = random.Next(67, 185);

        }

    }
}
