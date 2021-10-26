using System;

namespace LearnCSharp.AnonymousMethodsAndLambdaExpressions
{
    public class Lesson
    {
        public Lesson(string name)
        {
            Name = name;
        }
        
        public string Name { get; }
        public DateTime Begin { get; set; }

        public event EventHandler<DateTime> Started;

        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}