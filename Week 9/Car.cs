using System;
using System.Text;

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
        /// <param name="o">Объект для сравнения с данным экземпляром</param>
        /// <returns>
        /// Значение, указывающее, каков относительный порядок сравниваемых объектов.Возвращаемые
        /// значения представляют следующие результаты сравнения.Значение Значение Меньше
        /// нуля Данный экземпляр предшествует параметру other в порядке сортировки. Нуль
        /// Данный экземпляр занимает ту же позицию в порядке сортировки, что и параметр
        /// other. Больше нуля Данный экземпляр следует за параметром other в порядке сортировки.</returns>
        public int CompareTo(Car other)
        {
            if (Price > other.Price) return 1;
            if (Price < other.Price) return -1;
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
