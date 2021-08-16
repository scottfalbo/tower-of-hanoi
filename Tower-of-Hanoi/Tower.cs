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
                    new Poles(4),
                    new Poles(4),
                    new Poles(4)
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
                    new Poles(discs),
                    new Poles(discs),
                    new Poles(discs)
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
        public Tower Solve(int n, Poles startPole, Poles endPole, Poles centerPole)
        {




            return this;
        }

    }

    /// <summary>
    /// Pole class for the Poles array in the Tower object.
    /// </summary>
    public class Poles
    {
        public Stack<Discs> Pole { get; set; }

        public Poles(int discs)
        {
            Pole = new Stack<Discs>();
        }
    }

    /// <summary>
    /// Disc class for the Poles in the Tower.
    /// </summary>
    public class Discs
    {
        public string Disc { get; set; }
        public Discs(string disc)
        {
            Disc = disc;
        }
    }

}
