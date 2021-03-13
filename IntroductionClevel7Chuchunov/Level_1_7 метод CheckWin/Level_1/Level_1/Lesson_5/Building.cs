using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_5
{
    /// <summary>
    /// Здание
    /// </summary>
    [Serializable]
    public class Building
    {
        /// <summary>
        /// Количество этажей
        /// </summary>
        public int Floors { get; }

        /// <summary>
        /// Количество подъездов
        /// </summary>
        public int Entrances { get; }

        /// <summary>
        /// Признак отапливаемости здания
        /// </summary>
        public bool IsHeatable { get; set; }

        /// <summary>
        /// Адрес здания
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Создает здание с заданными параметрами
        /// </summary>
        /// <param name="floors">Количество этажей</param>
        /// <param name="entrances">Количество подъездов</param>
        public Building(int floors, int entrances)
        {
            Floors = floors;
            Entrances = entrances;
        }

        public Building()
        {
        }

        /// <summary>
        /// Вызывает лифт на заданный этаж
        /// </summary>
        /// <param name="entrance">Номер подъезда</param>
        /// <param name="floor">Номер этажа</param>
        public void GetElevator(int entrance, int floor)
        {
            Console.WriteLine("3..2..1..Ding!");
        }

        /// <summary>
        /// Открывает дверь заданного подъезда
        /// </summary>
        /// <param name="entrance">Номер подъезда</param>
        public void OpenDoor(int entrance)
        {
            Console.WriteLine("Please come in!");
        }
    }
}
