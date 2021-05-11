using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEx06
{
    class Heracross : Pokemon
    {
        public Heracross(string Name)
        {
            name = Name;
            attack = "Megahorn";
            team = "Team Rocket Prepare for trouble! And make it double! To protect the world from devastation! To unite all peoples within our nation! To denounce the evils of truth and love! To extend our reach to the stars above! Jessie! James! Team Rocket blasts off at the speed of light! Surrender now, or prepare to fight!";
            level = 1;
        }
        public override void Name()
        {
            Console.WriteLine($"My name is {name} I am on {team}");
        }
    }
}
