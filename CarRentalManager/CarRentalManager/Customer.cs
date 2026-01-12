using System.Collections.Generic;

namespace CarRentalManager
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Car> RentedCars { get; private set; }

        public Customer(string name)
        {
            Name = name;
            RentedCars = new List<Car>();
        }

        public bool RentCar(Car car)
        {
            if (car == null || !car.Rent())
                return false;

            RentedCars.Add(car);
            return true;
        }

        public bool ReturnCar(Car car)
        {
            if (!RentedCars.Contains(car))
                return false;

            car.ReturnCar();
            RentedCars.Remove(car);
            return true;
        }
    }
}
