namespace LearnCSharp.LINQ
{
    public class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public override string ToString() =>
            $"{Name} - {Energy}";
    }
}