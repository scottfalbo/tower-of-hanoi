using System;
using System.Collections.Generic;
using System.Text;

namespace Tower_of_Hanoi
{
    public class Tower
    {
        public Pole[] Poles { get; set; }

        public Tower(int discs)
        {
            Poles = new Pole[]
                { 
                    new Pole(discs),
                    new Pole(discs),
                    new Pole(discs)
                };
        }

        public Pole[] SolveTowerArray(int discs) =>
            SolveArray(discs, Poles[0], Poles[2], Poles[1]);


        public void SolveTowerPrint(int discs) =>
            SolvePrint(discs, Poles[0], Poles[2], Poles[1]);


        public Pole[] SolveArray(int n, Pole startPole, Pole endPole, Pole centerPole)
        {

            return Poles;
        }

        public void SolvePrint(int n, Pole startPole, Pole endPole, Pole centerPole)
        {

        }


    }

    public class Pole
    {
        public int[] Tower { get; set; }

        public Pole(int discs)
        {
            Tower = new int[discs];
        }
    }

}
