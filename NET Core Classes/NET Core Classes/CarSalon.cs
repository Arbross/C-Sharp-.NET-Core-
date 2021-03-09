using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Core_Classes
{
    class CarSalon
    {
        List<Car> cars = new List<Car>();
        public void AddCar(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
            }
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public override string ToString()
        {
            return ($"Cars : \n{String.Join("\t", cars)}\n");
        }
    }
}
