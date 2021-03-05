using NUnit.Framework;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Units;
using System.Drawing;

namespace Sbt.Test.Refactoring.Tests
{
    public class CompositTest
    {
        [TestCase]
        public void TestShouldTurnAndMoveInTheRightDirection()
        {
            var map = new Map(5, 5);
            var tractor = new Tractor(map);
            var wind = new Wind(map, Orientation.North);
            var stone = new Stone(map, new Point(2, 3));

            var testing = new Composit(map, new UnitCollection { tractor, wind, stone });

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(1, tractor.Position.X);
            Assert.AreEqual(0, tractor.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(1, tractor.Position.X);
            Assert.AreEqual(-1, tractor.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(0, tractor.Position.X);
            Assert.AreEqual(-1, tractor.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(0, tractor.Position.X);
            Assert.AreEqual(0, tractor.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.East, wind.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.South, wind.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.West, wind.Orientation);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(Orientation.North, wind.Orientation);

            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(2, stone.Position.X);
            Assert.AreEqual(3, stone.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            Assert.AreEqual(2, stone.Position.X);
            Assert.AreEqual(3, stone.Position.Y);

        }
    }
}
