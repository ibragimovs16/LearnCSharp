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
            Person person = new()
            {
                Name = "Seymur"
            };

            person.GoToSleep += PersonGoToSleep;
            person.GoToSleep += () => 
                Console.WriteLine("0_o");

            person.DoWork += (sender, e) =>
            {
                if (sender is Person) 
                    Console.WriteLine($"{((Person)sender).Name} working.");
            };

            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));
        }

        private void PersonGoToSleep()
        {
            Console.WriteLine("Person go to sleep.");
        }
    }
}
