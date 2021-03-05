using NUnit.Framework;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Units;

namespace Sbt.Test.Refactoring.Tests
{
    public class TractorTest
    {
        [TestCase]
        public void TestShouldMoveForward()
        {
            var testing = new Tractor(new Map(5, 5));

            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(0, testing.Position.X);
            Assert.AreEqual(1, testing.Position.Y);
        }

        [TestCase]
        public void TestShouldTurn()
        {
            var testing = new Tractor(new Map(5, 5));

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
        public void TestShouldTurnAndMoveInTheRightDirection()
        {
            var testing = new Tractor(new Map(5, 5));

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(1, testing.Position.X);
            Assert.AreEqual(0, testing.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(1, testing.Position.X);
            Assert.AreEqual(-1, testing.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(0, testing.Position.X);
            Assert.AreEqual(-1, testing.Position.Y);

            testing.ExecuteCommand(new TurnClockwiseCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            Assert.AreEqual(0, testing.Position.X);
            Assert.AreEqual(0, testing.Position.Y);
        }

        [TestCase]
        public void TestShouldThrowExceptionIfFallsOffPlateau()
        {
            var testing = new Tractor(new Map(5, 5));

            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());
            testing.ExecuteCommand(new MoveForwardCommand());

            try
            {
                testing.ExecuteCommand(new MoveForwardCommand());
                Assert.Fail("Tractor was expected to fall off the plateau");
            }
            catch (TractorInDitchException)
            {
            }
        }
    }
}
