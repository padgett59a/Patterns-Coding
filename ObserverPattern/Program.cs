using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockPublisher stockGrabber = new StockPublisher(); //Publisher
            StockObserver observer1 = new StockObserver(stockGrabber, "Observer One"); //Pass the publisher

            stockGrabber.setIbmPrice(197.00);
            stockGrabber.setAaplPrice(677.60);
            stockGrabber.setGoogPrice(676.40);

        }
    }
}
