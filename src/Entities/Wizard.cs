using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dungeon.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name,int level,string heroType)
        {   
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;       
        }

        public override string Attack() {
            return this.Name + " Attacked with her magic";
        }
        
        public string Attack(int bonus) {
            if(bonus > 6) {
                return  this.Name + $" Attacked with her super effective magic with {bonus} of attack bonus";
            } else {
                return  this.Name + $" Attacked with her magic with {bonus} of attack bonus";
            }
        }
    }
}