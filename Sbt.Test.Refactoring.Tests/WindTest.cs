using NUnit.Framework;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Units;

namespace Sbt.Test.Refactoring.Tests
{
    public class WindTest
    {
        [TestCase]
        public void TestShouldTurn()
        {
            var testing = new Wind(new Map(5, 5), Orientation.North);
            
            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.East, testing.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.South, testing.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.West, testing.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.North, testing.Orientation);
        }

        [TestCase]
        public void TestShouldNotChangeOrintationIfMoving()
        {
            var testing = new Wind(new Map(5, 5), Orientation.North);

            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(Orientation.North, Orientation.North);
        }
    }
}
