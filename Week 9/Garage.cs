using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{/// <summary>
/// Представляет коллекцию объектов типа Car
/// </summary>
    class Garage : IEnumerable<Car>
    {
        /// <summary>
        /// Коллекция объектов типа <c>Car</c>
        /// </summary>
        private List<Car> _listCars = new List<Car>();
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Garage() { }
        /// <summary>
        /// Конструктор принимающий неограниченое количество объектов типа Car
        /// </summary>
        /// <param name="cars">Принимает объекты типа Car</param>
        public Garage(params Car[] cars)
        {
            foreach (var car in cars)
            {
                _listCars.Add(car);
            }
        }
        /// <summary>
        /// Показывает содержимое всей коллекции
        /// </summary>
        /// <returns>Строка представляющая текущий объект</returns>
        public override string ToString()
        {
            foreach (var car in _listCars)
                Console.WriteLine(car);
            return "\n";
        }
        /// <summary>
        /// Добавляет новый элемент в конец коллекции
        /// </summary>
        /// <param name="car">Принимает объект типа Car</param>
        public void Add(Car car)
        {
            _listCars.Add(car);
        }
        /// <summary>
        /// Удаляет все элементы из коллекции
        /// </summary>
        /// <param name="car">Принимает объект типа Car</param>
        public void Clear(Car car)
        {
            _listCars.Clear();
        }
        /// <summary>
        /// сортирует коллекцию по возрастанию цены
        /// </summary>
        public void Sort()
        {
            _listCars.Sort();
        }
        /// <summary>
        /// Выбрает все машины у которых цена  больше 10_000
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Car> PriceMore10000()
        {
            return _listCars.Where(car => car.Price > 10_000);
        }
        /// <summary>
        /// Выбрает все машины красного цвета 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Car> RedCars()
        {
            return _listCars.Where(car => car.Color == "Red");
        }
        /// <summary>
        /// Выбрает все машины по заданной цене и марке машины
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Car> PriceMark()
        {
            return _listCars.Where(car => car.Mark == "Lada").Where(car => car.Price > 1_000);
        }
        /// <summary>
        /// Выводит сумму стоимости всех машин
        /// </summary>
        /// <returns></returns>
        public decimal SumCost()
        {
            return _listCars.Sum(s => s.Price);
        }
        /// <summary>
        /// Выводит сколько машин красного цвета
        /// </summary>
        /// <returns></returns>
        public int AmounRedCars()
        {
            return _listCars.Where(car => car.Color == "Red").ToList().Count;
        }
        /// <summary>
        /// Выбрает все дешевые машины (цена которых > 5000) и при помощи проекция выбраеть только марку и модель машин
        /// </summary>
        /// <returns></returns>
        public IEnumerable Cars()
        {
            var x = _listCars.Where(car => car.Price < 5_000).Select(car => new { Mark = car.Mark, Model = car.Model });
            return x;
        }
        /// <summary>
        /// Выбрает все машины(по цене) в диапазоне MIN - MAX и считает сколько машин красного, черного цвета
        /// </summary>
        /// <param name="min">минимальная цена диапазона</param>
        /// <param name="max">максимальная цена диапазона</param>
        /// <returns>Tuple тип (количество красных и черных машин в коллекции)</returns>
        public (int red, int black) CarsPrice(int min, int max)
        {
            var x = _listCars.Where(car => car.Price >= min && car.Price <= max).Where(car => (car.Color == "Red" || car.Color == "Black"));
            return (x.Where(c => c.Color == "Red").ToList().Count, x.Where(c => c.Color == "Black").ToList().Count);
        }
        /// <summary>
        /// Перебор элементов коллекции Car
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Car> GetEnumerator()
        {
            return _listCars.GetEnumerator();
        }
        /// <summary>
        /// Перебор элементов коллекции
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _listCars.GetEnumerator();
        }
    }
}