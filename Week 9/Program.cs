using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage(new Car() { Model = "X5", Mark = "BMW", Color = "Blue", Price = 70_000 },
                            new Car() { Model = "911", Mark = "Porsche", Color = "Red", Price = 50_000 },
                            new Car() { Model = "Vectra", Mark = "Opel", Color = "Grey", Price = 30_000 },
                            new Car() { Model = "AMG", Mark = "Mercedes-Benz", Color = "Brown", Price = 40_000 },
                            new Car() { Model = "Octavia", Mark = "Shkoda", Color = "Black", Price = 20_000 },
                            new Car() { Model = "Berlinetta", Mark = "Ferrari", Color = "White", Price = 250_000 },
                            new Car() { Model = "2102", Mark = "Lada", Color = "Red", Price = 1_000 },
                            new Car() { Model = "Lanos", Mark = "Daewoo", Color = "Green", Price = 4_600 },
                            new Car() { Model = "Pajero", Mark = "Mitsubishi", Color = "Red", Price = 38_000 },
                            new Car() { Model = "Omega", Mark = "Opel", Color = "Grey", Price = 63_000 },
                            new Car() { Model = "Accord", Mark = "Honda", Color = "Brown", Price = 4_000 },
                            new Car() { Model = "Fabia", Mark = "Shkoda", Color = "Black", Price = 28_000 },
                            new Car() { Model = "R7", Mark = "Ferrari", Color = "White", Price = 95_000 },
                            new Car() { Model = "2101", Mark = "Lada", Color = "Red", Price = 1_900 },
                            new Car() { Model = "Lanos", Mark = "Daewoo", Color = "Green", Price = 6_600 },
                            new Car() { Model = "Nubira", Mark = "Daewoo", Color = "Black", Price = 11_800 });
            garage.Sort();
            //1. Выбрать все машины у которых цена  больше 10_000
            Console.WriteLine("Cars whose price more than 10_000 $\n\n");
            var a = garage.PriceMore10000();
            foreach (var car in a)
                Console.WriteLine(car);
            Console.ReadKey();
            Console.Clear();
            //2. Выбрать все машины красного цвета
            Console.WriteLine("Cars with red color\n\n");
            var b = garage.RedCars();
            foreach (var car in b)
                Console.WriteLine(car);
            Console.ReadKey();
            Console.Clear();
            //3. Выбрать все машины по заданной цене и марке машины
            Console.WriteLine("All red Lada,more than 1 000 $\n\n");
            var c = garage.PriceMark();
            foreach (var car in c)
                Console.WriteLine(car);
            Console.ReadKey();
            Console.Clear();
            //4. Вывести сумму стоимости всех машин
            Console.WriteLine($"Total cost of all cars : {garage.SumCost()}\n\n");
            Console.ReadKey();
            Console.Clear();
            //5. Вывести сколько машин красного цвета
            Console.WriteLine($"Amount red cars is : {garage.AmounRedCars()}\n\n");
            Console.ReadKey();
            Console.Clear();
            //6. Выбрать все дешевые машины (цена < 5_000) и при помощи проекция выбрать только марку и модель машин
            Console.WriteLine("Cars cost < 5_000 \n\n");
            var d = garage.Cars();
            foreach (var car in d)
                Console.WriteLine(car);
            Console.ReadKey();
            Console.Clear();
            //7. Выбрать все машины(по цене) в диапазоне заданным пользователем и посчитайте сколько машин красного, черного цвета
            bool isCorrect = false;
            int min = 0, max = 0;
            while (!isCorrect)
            {
                try
                {
                    Console.Write("Введите диапазон цен авто :\nMIN = ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("\nMAX = ");
                    max = int.Parse(Console.ReadLine());
                    if (min > max)
                    {
                        int tmp = min;
                        min = max;
                        max = tmp;
                    }
                    isCorrect = true;
                }
                catch
                {
                    Console.WriteLine($"Неверный ввод данных\n");
                }
            }
            var x = garage.CarsPrice(min, max);
            Console.WriteLine($"Red cars   : {x.red}\nBlack cars : {x.black}\n");
        }
    }
}
