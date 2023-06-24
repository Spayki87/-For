using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освоение_циклов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int userNumber;
            int repetitionsNumber;

            Console.WriteLine("Введите сообщение, которое хотите повторить:");
            userMessage = Console.ReadLine();
            Console.WriteLine("Введите количество повторений сообщения:");
            userNumber = Convert.ToInt32(Console.ReadLine());

            for (repetitionsNumber = 0; repetitionsNumber < userNumber; repetitionsNumber++)
            {
                Console.WriteLine(userMessage);
            }
        }
    }
}
