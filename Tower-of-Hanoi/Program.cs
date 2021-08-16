using System;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTower of Hanoi");
            int discs = 0;

            while (discs < 3 || discs > 10)
            {
                Console.WriteLine("Enter the number of discs to use. (3-10)");
                discs = Convert.ToInt32(Console.ReadLine());
            }
            Tower tower = new Tower(discs);
            tower.SolveTower();
            Console.WriteLine($"Total moves: {tower.Moves}");
        }
    }
}
