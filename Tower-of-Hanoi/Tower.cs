using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_of_Hanoi
{
    public class Tower
    {
        public Poles[] Poles { get; set; }

        public Tower(int discs)
        {
            Poles = new Poles[]
                { 
                    new Poles(discs),
                    new Poles(discs),
                    new Poles(discs)
                };
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
        public Discs[] Pole { get; set; }

        public Poles(int discs)
        {
            Pole = new Discs[discs];
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
