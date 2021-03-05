namespace Sbt.Test.Refactoring.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var tractorTest = new TractorTest();

            tractorTest.TestShouldMoveForward();
            tractorTest.TestShouldThrowExceptionIfFallsOffPlateau();
            tractorTest.TestShouldTurn();
            tractorTest.TestShouldTurnAndMoveInTheRightDirection();

            var stoneTest = new StoneTest();
            stoneTest.TestShouldNotChangePosition();

            var windTest = new WindTest();
            windTest.TestShouldNotChangeOrintationIfMoving();
            windTest.TestShouldTurn();

            var compositTest = new CompositTest();
            compositTest.TestShouldTurnAndMoveInTheRightDirection();
        }
    }
}
