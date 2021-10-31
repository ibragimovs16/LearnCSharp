namespace LearnCSharp.ObjectType
{
    public class OverridePoint
    {
        public int X { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is OverridePoint point) return point.X == X;
            
            return false;
        }

        public override int GetHashCode() => X;

        public OverridePoint Clone() =>
            MemberwiseClone() as OverridePoint;
    }
}