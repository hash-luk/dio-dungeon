using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dungeon.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name,int level, string heroType) {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero() {
            
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return $"Name: {this.Name} \nLevel: {this.Level} \nHero Type: {this.HeroType}";
        }

        public virtual string Attack() {
            return this.Name + " Attacked with his sword";
        }
    }
}