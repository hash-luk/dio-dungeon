using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dungeon.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name,int level,string heroType)
        {   
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;       
        }

        public string Attack(int bonus) {
            if(bonus > 6) {
                return  this.Name + $" Attacked with his super effective sword with {bonus} of attack bonus";
            } else {
                return  this.Name + $" Attacked with his sword with {bonus} of attack bonus";
            }
        }
    }
}