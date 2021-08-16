using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_of_Hanoi
{
    public class Tower
    {
        public Poles[] Poles { get; set; }

        public int Moves = 0;

        /// <summary>
        /// Default constructor with 4 discs.
        /// </summary>
        public Tower() 
        {
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
        /// </summary>
        /// <param name="discs"> int: number of discs </param>
        public Tower(int discs)
        {
            Poles = new Poles[]
                { 
                    new Poles(discs),
                    new Poles(discs),
                    new Poles(discs)
                };
            for (int i = discs; i > 0; i--)
                Poles[0].Pole.Push(new Discs($"Disc-{i}"));
        }

        public Poles[] SolveTowerArray(int discs) =>
            SolveArray(discs, Poles[0], Poles[2], Poles[1]);


        public void SolveTowerPrint(int discs) =>
            SolvePrint(discs, Poles[0], Poles[2], Poles[1]);


        public Poles[] SolveArray(int n, Poles startPole, Poles endPole, Poles centerPole)
        {

            return Poles;
        }

        public void SolvePrint(int n, Poles startPole, Poles endPole, Poles centerPole)
        {

        }


    }

    public class Poles
    {
        public Stack<Discs> Pole { get; set; }

        public Poles(int discs)
        {
            Pole = new Stack<Discs>();
        }
    }

    public class Discs
    {
        public string Disc { get; set; }
        public Discs(string disc)
        {
            Disc = disc;
        }
    }

}
