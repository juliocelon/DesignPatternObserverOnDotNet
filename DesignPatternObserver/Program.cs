using System;

namespace DesignPatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSite webSite = new WebSite();

            Subscriber subscriber1 = new Subscriber(webSite);
            Subscriber subscriber2 = new Subscriber(webSite);

            webSite.Attach(subscriber1);
            webSite.Attach(subscriber2);

            webSite.AddNewArticle("New Article 1");
        }
    }




}
