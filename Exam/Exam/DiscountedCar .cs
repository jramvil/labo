using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class DiscountedCar : Car
    {
        public DiscountedCar(string carMake, string model, double price, int discount) : base(carMake, model, price)
        { 
            this._discount = discount;
            discountedCarCounter++;

        }

        protected int _discount;

        protected static int discountedCarCounter = 0;


        public static int CountDiscountedCar()
        {
            return discountedCarCounter;
        }

        public virtual void sell()
        {
            if(_booking == false)
            {
                double newPrice = _price * ((100 - _discount) / 100);
                this._sold = true;
                discountedCarCounter--;
                Console.WriteLine("The discounted car {0} is sold for {1}", this._model, newPrice);
            }
            else
                Console.WriteLine("The car is booked, is not possible to sell it");

        }

        // Public properties
        public string carMake
        {
            get { return _carMake; }
            set { _carMake = value; }
        }
        public string model
        {
            get { return _model; }
            set { _model = model; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool sold
        {
            get { return _sold; }
            set { _sold = value; }
        }
        public bool booking
        {
            get { return _booking; }
            set { _booking = value; }
        }
        public int discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

    }
}
