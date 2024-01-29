using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    interface ICars
    {
        void bookCar();
        void sell();
    }



    public class Car : ICars
    {
        public Car(string carMake, string model, double price, bool sold, bool booking)
        {
            this.carMake= carMake;
            this.model = model;
            this.price = price;
            this.sold = sold;
            this.booking = booking;
        }

        public Car(string carMake, string model, double price)
        {
            _carMake = carMake;
            _model = model;
            _price = price;
        }

        protected string _carMake;
        protected string _model;
        protected double _price;
        protected bool _sold;
        protected bool _booking;

        // Properties
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


        public void bookCar()
        {
            if (_sold == false)
            {
                _booking = true;
                Console.WriteLine("¡¡¡Booking succes!!!");
            }
            else
            {
                Console.WriteLine("The car is sold, impossible to book it");
            }
        }


        public virtual void sell()
        {
            if (_booking == false)
            {
                _sold = true;
                Console.WriteLine("¡¡¡Sell succes!!!");
            }
            else
            {
                Console.WriteLine("The car is booked");
            }
        }

        public static void ShowCars(List<Car> cars)
        {
            foreach(Car car in cars)
            {
                Console.Write("{0}\t{1}\t{2}\t\n", car.carMake, car.model, car.price);
                
            }

        }

        public static void SoldCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if(car.sold == true)
                Console.Write("{0}\t{1}\t{2}\t\n", car.carMake, car.model, car.price);
            }
        }

        public static void ReservedCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.booking == true)
                    Console.Write("{0}\t{1}\t{2}\t\n", car.carMake, car.model, car.price);
            }
        }

        public static double AveragePrice(List<Car> cars)
        {
            int counter = 0;
            double total_price = 0;
            foreach (Car car in cars)
            {
                if (car.sold == true)
                {
                    total_price = total_price + car.price;
                    counter++;
                }

            }
            
            double average = total_price / counter;
            return average;
        }


    }
}
