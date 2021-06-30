namespace Game.Core.GameWorld
{
    //public record Position
    //{
    //    public int X { get; }
    //    public int Y { get; }

    //    public Position(int y, int x)
    //    {
    //        Y = y;
    //        X = x;
    //    }

    //    public static Position operator +(Position p1, Position p2) =>
    //        new Position(p1.Y + p2.Y, p1.X + p2.X);
    //}

    //public record Position
    //{
    //    public int X { get; init; }
    //    public int Y { get; init; }

    //    public Position(int y, int x) => (Y, X) = (y, x);
    //    //{
    //    //    Y = y;
    //    //    X = x;
    //    //}
    //    public static Position operator +(Position p1, Position p2) =>
    //       new Position(p1.Y + p2.Y, p1.X + p2.X);
    //}

    public record Position(int Y, int X)
    {
        public static Position operator +(Position p1, Position p2) =>
           new(p1.Y + p2.Y, p1.X + p2.X);
    }
}