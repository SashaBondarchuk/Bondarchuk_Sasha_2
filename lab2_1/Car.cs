using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    public class Car
    {
        public float Price { get; set; }
        public float MaxSpeed { get; set; }
        public float FuelConsumption { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return $"Модель: {Model}\nЦіна: {Price}\nРозхід (л/100км): {FuelConsumption}\nМаксимальна швидкість: {MaxSpeed}";
        }
        public static Car GetCar()
        {
            Car car = new Car();
            Console.Write("Модель: ");
            car.Model = Console.ReadLine();
            Console.Write("Максимальна швидкість: ");
            car.MaxSpeed = float.Parse(Console.ReadLine());
            Console.Write("Ціна: ");
            car.Price = float.Parse(Console.ReadLine());
            Console.Write("Розхід (л/100км): ");
            car.FuelConsumption = float.Parse(Console.ReadLine());
            return car;
        }
    }
}