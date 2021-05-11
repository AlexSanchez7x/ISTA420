using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class Pokemon
    {
        public string name;
        public string team;
        public string attack;
        public int level;

        public virtual void Name()
        {
            Console.WriteLine($"This is {name}");
        }
        public virtual void Attack(Pokemon target)
        {
            // we can do more things here aka add a parameter for target
            Console.WriteLine($"{name} uses {attack} on {target.name}");
        }
        public virtual void Team()
        {


        }

        public void ChangeATK(string MyAtk)
        {
            attack = MyAtk;
            Console.WriteLine($"{name} has learned {MyAtk}");
        }

        public void LevelUp()
        {
            level++;
            Console.WriteLine($"{name} has Gained a level and is now level {level}");
        }
        
    }
}
