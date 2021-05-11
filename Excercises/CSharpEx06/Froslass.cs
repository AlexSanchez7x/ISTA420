using System;

namespace CSharpEx06
{
    class Froslass : Pokemon
    {
        public Froslass(string Name)
        {
            name = Name;
            attack = "ShadowBall";
            team = "Team Galactic";
            level = 30;
            
        }
        public override void Name()
        {
            Console.WriteLine($"My name is {name} I am on {team}");
        }
    }
}
