using System;

namespace LearnCSharp.DelegatesAndEvents
{
    public class Events
    {
        public delegate void MyDelegate();

        //public event MyDelegate myEvent;
        public event Action myEvent;

        public Events()
        {
            Person person = new("Seymur");

            person.GoToSleep += () =>
                Console.WriteLine("Person going to sleep.");

            person.DoWork += (sender, e) =>
            {
                if (sender is Person currentPerson)
                    Console.WriteLine($"{currentPerson.Name} working.");
            };

            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));
        }
    }
}
