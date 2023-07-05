using System;
using MyLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment(1, "Танашов");//Студент Танашов Амир

            // Добавление объектов дополнительного класса
            apartment.AddRoom(new Room("Гостиная", 30));
            apartment.AddRoom(new Room("Спальня", 20));
            apartment.AddRoom(new Room("Кухня", 15));

            // Показать информацию обо всех объектах дополнительного класса
            apartment.ShowAll();

            // Сортировка и показ информации обо всех объектах дополнительного класса
            apartment.Rooms.Sort();
            apartment.ShowAll();

            Console.ReadLine();
        }
    }
}
