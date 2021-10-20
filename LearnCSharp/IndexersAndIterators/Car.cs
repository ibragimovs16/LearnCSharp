namespace LearnCSharp.IndexersAndIterators
{
    public class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString() =>
            $"{Name}, {Number}";
    }
}