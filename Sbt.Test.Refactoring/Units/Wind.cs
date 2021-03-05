using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring.Units
{
    public class Wind : UnitBase
    {
        private static readonly System.Type TURN_CLOCK_WISE = typeof(TurnClockwiseCommand);

        private Orientation orientation;

        public Wind(Map map) : this(map, Orientation.North) { }

        public Wind(Map map, Orientation o) : base(map)
        {
            orientation = o;
        }

        public Orientation Orientation => orientation;

        public override void ExecuteCommand(CommandBase command)
        {
            base.ExecuteCommand(command);

            if (command.GetType() == TURN_CLOCK_WISE)
            {
                TurnClockwise();
            }
        }

        private void TurnClockwise()
        {
            orientation = orientation.GetNext();
        }
    }
}
