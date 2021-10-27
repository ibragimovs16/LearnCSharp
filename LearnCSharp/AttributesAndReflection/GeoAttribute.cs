using System;

namespace LearnCSharp.AttributesAndReflection
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    public class GeoAttribute : Attribute
    {
        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}