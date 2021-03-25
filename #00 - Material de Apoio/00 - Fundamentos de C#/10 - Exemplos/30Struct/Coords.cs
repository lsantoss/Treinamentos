namespace _30Struct
{
    public struct Coords
    {
        public double X { get; }
        public double Y { get; }

        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}