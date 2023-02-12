using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePokemon
{
    public class Pokemon
    {
        protected string name;
        protected int HP;
        protected int attack;
        protected int speed;
        protected int defense;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName()
        {
            return name;
        }
        public int getHP()
        {
            return HP;
        }
        public int getAtk() { return attack; }
        public int getSpeed() { return speed; }
        public int getDefense() { return defense; }
        public void takeDamage(int damage)
        {
            if (damage > 0)
            {
                HP -= damage;
            }
            else
            {
                damage = 0;
            }


        }
        public void IncreaseHP(int amount)
        {
            HP += amount;
        }
        public void IncreaseDef(int number)
        {
            defense = number;
        }

    }

}