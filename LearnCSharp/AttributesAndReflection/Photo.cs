namespace LearnCSharp.AttributesAndReflection
{
    public class Photo
    {
        public Photo(string name)
        {
            Name = name;
        }
        
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }
    }
}