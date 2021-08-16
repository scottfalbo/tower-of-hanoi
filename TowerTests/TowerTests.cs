using System;
using Tower_of_Hanoi;
using Xunit;

namespace TowerTests
{
    public class TowerTests
    {
        [Fact]
        public void CanSuccessfullyCreatePoles()
        {
            Tower tower = new Tower();
            int expected = 3;
            int actual = tower.Poles.Length;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullyCreateTowerOfDiscs()
        {
            Tower tower = new Tower();
            string expected = "Disc-1";
            string actual = tower.Poles[0].Pole.Peek().Disc;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullyCreateATowerOfNDiscs()
        {
            Tower tower = new Tower(7);
            int expected = 7;
            int actual = tower.Poles[0].Pole.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullyMoveDiscsFromPoleToPole() 
        {
            Tower tower = new Tower();
            tower.Poles[2].Pole.Push(tower.Poles[0].Pole.Pop());
            tower.Poles[1].Pole.Push(tower.Poles[0].Pole.Pop());
            string expected = "Disc-2";
            string actual = tower.Poles[1].Pole.Peek().Disc;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullySolveTheTowerOfHanoi()
        {
            Tower tower = new Tower();
            string expected = "Disc-1";
            string actual = tower.Poles[2].Pole.Peek().Disc;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullyCountNumberOfMovesToComplete()
        {
            Tower tower = new Tower(8);
            // 2^n - 1 where n is the number of discs
            int expected = 255;
            int actual = tower.Moves;
            Assert.Equal(expected, actual);
        }
    }
}
