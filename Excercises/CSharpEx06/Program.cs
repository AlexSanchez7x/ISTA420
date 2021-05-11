using System;

namespace CSharpEx06
{
    class Program
    {
        static void Main(string[] args)
        {
            Froslass phil = new Froslass("Froslass");
            Heracross Beetle = new Heracross("Heracross");
            Beetle.Name();
            Beetle.Attack(phil);
            Beetle.Team();
            Beetle.ChangeATK("Close Combat");
            Beetle.LevelUp();

            Console.WriteLine();
            
            phil.Name();
            phil.Attack(Beetle);
            phil.Team();
            phil.ChangeATK("Ice Beam");
            phil.Attack(Beetle);
            phil.LevelUp();
            //Console.WriteLine($"{phil.name} {phil.attack}");
        }
    }
}
