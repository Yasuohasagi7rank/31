using System;

namespace _9._89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string a = Console.ReadLine();

            a = a.Replace('е', 'и');

            Console.WriteLine(a);
        }
    }
}
