using System;
using Tower_of_Hanoi;
using Xunit;

namespace TowerTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullySolveATower()
        {
            Tower tower = new Tower(4);
            Poles[] poles = tower.SolveTowerArray(4);

        }
    }
}
