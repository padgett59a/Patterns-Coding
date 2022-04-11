using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockObserver : IObserver
    {
        
        public double ibmPrice { get; set; }
        public double googPrice { get; set; }
        public double aaplPrice { get; set; }

        private static int obsIdCounter = 0;
        private string name;
        private int observerID;

        private ISubject stockGrabber;

        public StockObserver(ISubject pObserver, string pName)
        {
            this.name = pName;
            this.stockGrabber = pObserver;
            this.observerID = ++obsIdCounter;
            Console.WriteLine($"Observer ID {this.observerID} has been created.");
            stockGrabber.register(this);
        }
        public void update(double pIbmPrice, double pAaplPrice, double pGoogPrice)
        {
            this.ibmPrice = pIbmPrice;
            this.aaplPrice = pAaplPrice;
            this.googPrice = pGoogPrice;
            this.printPrices();
        }

        public void printPrices()
        {
            string priceStr = @$"From {this.name}, ID: {this.observerID}
            IBM: {this.ibmPrice}
            AAPL: {this.aaplPrice}
            Google: {this.googPrice}
            ";
            Console.WriteLine(priceStr);
        }
    }
}
