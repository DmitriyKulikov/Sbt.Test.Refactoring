using Sbt.Test.Refactoring.Commands;
using System;
using System.Drawing;

namespace Sbt.Test.Refactoring.Units
{
    public class Stone : UnitBase
    {
        private Point position;

        public Stone(Map map, Point position) : base(map)
        {
            if (position.X > Map.Width || position.Y > Map.Height)
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }

            this.position = position;
        }

        public Point Position => position;

        public override void ExecuteCommand(CommandBase command) { /*do nothing*/ }
    }
}
