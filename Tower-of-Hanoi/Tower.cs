using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_of_Hanoi
{
    public class Tower
    {
        public Poles[] Poles { get; set; }

        public int Moves = 0;

        public int Discs { get; set; }

        /// <summary>
        /// Default constructor with 4 discs.
        /// Instantiates a new Tower object with an array of Pole objects.
        /// Instantiates and pushes the default 4 Disc objects into the first Pole stack.
        /// </summary>
        public Tower() 
        {
            Discs = 4;
            Poles = new Poles[]
                {
                    new Poles(4, 1),
                    new Poles(4, 2),
                    new Poles(4, 3)
                 };
            for (int i = 4; i > 0; i--)
                Poles[0].Pole.Push(new Discs($"Disc-{i}"));
        }

        /// <summary>
        /// Constructor for user inputted number of discs.
        /// Instantiates a new Tower object with an array of Pole objects.
        /// Instantiates and pushes the n Disc objects into the first Pole stack.
        /// </summary>
        /// <param name="discs"> int: number of discs </param>
        public Tower(int discs)
        {
            Discs = discs;
            Poles = new Poles[]
                { 
                    new Poles(discs, 1),
                    new Poles(discs, 2),
                    new Poles(discs, 3)
                };
            for (int i = discs; i > 0; i--)
                Poles[0].Pole.Push(new Discs($"Disc-{i}"));
        }

        /// <summary>
        /// Method to solve the tower and return a mutated Poles array.
        /// </summary>
        /// <returns></returns>
        public Tower SolveTower() =>
            Solve(Discs, Poles[0], Poles[2], Poles[1]);

        public Tower Solve(int n, Poles from, Poles to, Poles holder)
        {
            Discs disc = new Discs();
            Moves++;

            if (n == 1)
            {
                disc = from.Pole.Pop();
                to.Pole.Push(disc);
                Console.WriteLine($"Move {disc.Disc} from Pole {from.Position} to Pole {to.Position}");
                return this;
            }

            Solve(n - 1, from, holder, to);

            disc = from.Pole.Pop();
            to.Pole.Push(disc);
            Console.WriteLine($"Move {disc.Disc} from Pole {from.Position} to Pole {to.Position}");

            Solve(n - 1, holder, to, from);

            return this;
        }

    }

    /// <summary>
    /// Pole class for the Poles array in the Tower object.
    /// </summary>
    public class Poles
    {
        public Stack<Discs> Pole { get; set; }
        public int Position { get; set; }

        public Poles(int discs, int posistion)
        {
            Pole = new Stack<Discs>();
            Position = posistion;
        }
    }

    /// <summary>
    /// Disc class for the Poles in the Tower.
    /// </summary>
    public class Discs
    {
        public string Disc { get; set; }
        public Discs() { }
        public Discs(string disc)
        {
            Disc = disc;
        }
    }

}
