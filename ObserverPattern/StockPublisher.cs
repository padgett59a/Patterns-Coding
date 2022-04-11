using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockPublisher : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice { get; set; }

        public double getIbmPrice() { return ibmPrice; }
        public double getAaplPrice() { return aaplPrice; }
        public double getGoogPrice() { return googPrice; }

        public void setIbmPrice(double pNewPrice)
        {
            this.ibmPrice = pNewPrice;
            notifyObservers();
        }
        public void setGoogPrice(double pNewPrice)
        {
            this.googPrice = pNewPrice;
            notifyObservers();
        }
        public void setAaplPrice(double pNewPrice)
        {
            this.aaplPrice = pNewPrice;
            notifyObservers();
        }

        public StockPublisher()
        {
            List<IObserver> observers = new List<IObserver>();
        }
        public async void notifyObservers()
        {
            Task notifyObserversTask = new Task(notifyObserversSync);
            Console.WriteLine("Starting notifyObservers Async Task");
            notifyObserversTask.Start();
            await notifyObserversTask;
            Console.WriteLine("notifyObservers Async Task is complete.");
        }

        public void notifyObserversSync()
        {
            observers.ForEach(o => o.update(ibmPrice, aaplPrice, googPrice));
        }
        public void register(IObserver pObserver)
        {
            observers.Add(pObserver);
        }

        public void unregister(IObserver pObserver)
        {
            observers.Remove(pObserver);
        }

        
    }
}
