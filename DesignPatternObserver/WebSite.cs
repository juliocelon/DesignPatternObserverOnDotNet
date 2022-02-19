using System;
using System.Collections.Generic;

namespace DesignPatternObserver
{
    public interface IObservable // Entity to observe or notify
    {
        public void Attach(Subscriber subscriber);
        public void Detach(Subscriber subscriber);
        public void Notify();
    }

    public class WebSite : IObservable
    {
        List<Subscriber> subscribers = new List<Subscriber>();
        private string lastArticle;

        public string LastArticle { get => lastArticle; set => lastArticle = value; }

        public void Attach(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Detach(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.update();
            }
        }

        public void AddNewArticle(string message)
        {
            Console.WriteLine("New article added:[{0}]", message);
            LastArticle = message;
            Notify();
        }
    }
}
