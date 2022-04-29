using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість машин: ");
            int count = int.Parse(Console.ReadLine());
            AutoPark autoPark = new AutoPark(count);

            Console.WriteLine($"\nЦіна автопарку: {autoPark.TotalPrice()}");
            Console.WriteLine("\nСортування за розходом палива:");
            autoPark.SortByFuelConsumption();
            autoPark.FindBySpeedRange();            
        }
    }
}