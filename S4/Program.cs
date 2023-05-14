using System;

namespace S4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player mainCharacter = new Player("Andrew");

            mainCharacter.AddEXP(100);

            Console.WriteLine($"---- {mainCharacter.Name} ----");
            Console.WriteLine($"LEVEL: {mainCharacter.Level}");
            Console.WriteLine($"EXP: {mainCharacter.EXP} / {mainCharacter.EXP_Required}");
            Console.WriteLine($"HEALTH: {mainCharacter.Health}");
            Console.WriteLine($"ATTACK: {mainCharacter.Attack}");
            

        }
    }
}
