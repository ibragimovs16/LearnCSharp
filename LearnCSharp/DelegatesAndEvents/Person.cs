using System;

namespace LearnCSharp.DelegatesAndEvents
{
    public class Person
    {
        public Person(string name) =>
            Name = name;
        
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; }
        
        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8) GoToSleep?.Invoke();
            else DoWork?.Invoke(this, null!);
        }
    }
}
