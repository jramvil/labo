using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Exam
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Car> ShowRoom = new List<Car>();

            Car car1 = new Car("Mercedes", "A", 50000);
            Car car2 = new Car("Audi", "RS5", 60000);
            Car car3 = new Car("Toyota", "Yaris", 10000);
            Car car4 = new Car("BMW", "M2", 40000);

            DiscountedCar car5 = new("Tesla", "Y", 25000, 10);
            DiscountedCar car6 = new("Nissan", "Pulsar", 13000, 25);

            ShowRoom.Add(car1);
            ShowRoom.Add(car2);
            ShowRoom.Add(car3);
            ShowRoom.Add(car4);
            ShowRoom.Add(car5);
            ShowRoom.Add(car6);


            Console.WriteLine("We have this cars: \n");
            Car.ShowCars(ShowRoom);

            Console.WriteLine("---------------------------------");
            car1.sell();
            car3.sell();
            Console.WriteLine("---------------------------------");


            Console.WriteLine("This cars are sold: \n");
            Car.SoldCars(ShowRoom);

            Console.WriteLine("---------------------------------");
            car2.bookCar();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("This cars are reserved: \n");
            Car.ReservedCars(ShowRoom);

            Console.WriteLine("The average price of sold cars is: ");
            Console.WriteLine(Car.AveragePrice(ShowRoom));

        }
    }
}
