using Sbt.Test.Refactoring.Commands;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.Units
{
    public class UnitCollection : List<UnitBase>
    {
        public UnitCollection() : base(32) { }

        public void ExecuteCommand(CommandBase command)
        {
            foreach (var unit in this)
            {
                unit.ExecuteCommand(command);
            }
        }
    }
}
