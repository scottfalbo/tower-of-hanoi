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
    }
}
