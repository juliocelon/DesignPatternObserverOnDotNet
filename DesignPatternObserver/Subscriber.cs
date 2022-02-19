using System;
namespace DesignPatternObserver
{
    public interface IObserver // client or suscriptor
    {
        public void update();
    }

    public class Subscriber : IObserver
    {
        private WebSite webSite = null; // observable

        public Subscriber(IObservable webSite)
        {
            this.webSite = (WebSite)webSite;
        }

        public void update()
        {
            Console.WriteLine("New article published on the Web Site: [{0}]", webSite.LastArticle);
        }

    }
}
