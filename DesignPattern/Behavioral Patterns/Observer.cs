using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral_Patterns
{
    //Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
    class Observer
    {
       public static void RunDemo()
        {
            Stock bidv = new Stock("BIDV", 0);
            bidv.Attach(new Investor("Hai"));
            bidv.Attach(new Investor("Thai"));

            bidv.Price = 5;
            bidv.Price = 50;
        }
    }

    interface IInvestor
    {
        void Notify(Stock stock);
    }

    class Investor : IInvestor
    {
        public string Name { get; set; }
        public Stock Stock { get; set; }

        public Investor(string name)
        {
            this.Name = name;
        }

        public void Notify(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
        "change to {2:C} at {3}", this.Name, stock.Name, stock.Price,DateTime.Now.ToString());
        }
    }



    class Stock
    {
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();


        public string Name { get; set; }
        public Stock(string name, double price)
        {
            this.Name = name;
            this._price = price;

        }
        // Gets or sets the price

        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }

        }
        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Notify(this);
            }

            Console.WriteLine("");
        }

    }
}
