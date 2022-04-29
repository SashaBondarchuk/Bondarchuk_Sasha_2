using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class AutoPark
    {
        private List<Car> Cars = new List<Car>();
        public AutoPark(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nЗаповніть характеристики машини {i + 1}:");
                Cars.Add(Car.GetCar());
            }
        }
        public void SortByFuelConsumption()
        {
            List<Car> result = Cars.OrderBy(y => y.FuelConsumption).ToList();
            PrintCars(cars: result);
        }
        public void FindBySpeedRange()
        {
            Console.WriteLine("Введіть мінімальну і максимальну швидкість: ");
            float minSpeed = float.Parse(Console.ReadLine()), maxSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine();
            try
            {
                Console.WriteLine(Cars.Where(i => i.MaxSpeed > minSpeed && i.MaxSpeed < maxSpeed).First());
            }
            catch (Exception)
            {
                Console.WriteLine("Такої машини немає в списку");
            }
        }
        public float TotalPrice()
        {
            float sum = 0;
            foreach (Car car in Cars)
                sum += car.Price;
            return sum;
        }
        public void PrintCars()
        {
            foreach (var car in Cars)
                Console.WriteLine(car + "\n");
        }
        public void PrintCars(List<Car> cars)
        {
            foreach (var car in cars)
                Console.WriteLine(car + "\n");
        }
    }
}