using System;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower(4);
            Console.WriteLine(tower);
        }
    }
}
