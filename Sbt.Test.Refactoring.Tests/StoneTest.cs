using NUnit.Framework;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Units;
using System.Drawing;

namespace Sbt.Test.Refactoring.Tests
{
    public class StoneTest
    {
        [TestCase]
        public void TestShouldNotChangePosition()
        {
            var testing = new Stone(new Map(5, 5), new Point(2, 3));

            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(2, testing.Position.X);
            Assert.AreEqual(3, testing.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(2, testing.Position.X);
            Assert.AreEqual(3, testing.Position.Y);
        }
    }
}
