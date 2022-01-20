using System;

namespace GB_lesn01v3
{
    class Program
    {
        static void Main()
        {
            //Запрос ввода имени
            string nameUsr = Console.ReadLine();
            //Вывод приветствия
            Console.WriteLine("Привет, " + nameUsr +", сегодня " + DateTime.Now.ToShortDateString());
        }
    }
}
