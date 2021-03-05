using Sbt.Test.Refactoring.Commands;

namespace Sbt.Test.Refactoring.Units
{
    public class Composit : UnitBase
    {
        private UnitCollection units;

        public Composit(Map map, UnitCollection collection) : base(map)
        {
            units = collection;
        }

        public override void ExecuteCommand(CommandBase command)
        {
            units.ExecuteCommand(command);
        }
    }
}
