namespace Sbt.Test.Refactoring
{
    public static class OrientationExts
    {
        public static Orientation GetNext(this Orientation _orientation)
        {
            if (_orientation == Orientation.North)
            {
                return Orientation.East;
            }
            else if (_orientation == Orientation.East)
            {
                return Orientation.South;
            }
            else if (_orientation == Orientation.South)
            {
                return Orientation.West;
            }
            else if (_orientation == Orientation.West)
            {
                return Orientation.North;
            }

            throw new System.ArgumentException();
        }
    }
}
