using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: "); // вывод на экран строки с просьбой пользователя ввести своё имя.
            string name = Console.ReadLine(); // присвоение лок.переменной "name" с введённым ранее именем строкового типа "string".
            Console.WriteLine($"Привет {name}"); // вывод строки "Привет {name}" с указанным ранее именем на экран.
            Console.ReadKey(); // ожидание нажатия пользователем любой клавиши для закрытия консоли.
        }
    }
}