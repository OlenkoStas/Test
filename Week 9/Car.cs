using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{/// <summary>
/// Представляет автомобиль
/// </summary>
    class Car : IComparable<Car>
    {
        /// <summary>
        /// Марка авто
        /// </summary>
        public string Mark { get; set; }
        /// <summary>
        /// Модель авто
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Цена авто
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Цвет авто
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Сравнивает два объекта типа Car
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int CompareTo(Car o)
        {
            if (Price > o.Price) return 1;
            if (Price < o.Price) return -1;
            return 0;
        }
        /// <summary>
        /// Представляет объект типа Car в виде строки текста
        /// </summary>
        /// <returns>Строка представляющая текущий объект</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Mark  : {Mark}\nModel : {Model}\nColor : {Color}\nPrice : {Price} $\n");
            str.Append(new string('*', 20));
            return str.ToString();
        }
    }
}
