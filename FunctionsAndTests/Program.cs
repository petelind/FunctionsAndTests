using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndTests
{

    class Program
    {

        static void Main(string[] args)
        {
            
            /// Это окончательная версия со всеми исправленными ошибками, но!..
            /// TODO: Сделай так, чтоб программа завершалась если введены 00
            // нам понадобится переменная для ширины двора, и она может быть дробной
            double width;
            // нам понадобится переменная для длины двора, и она может быть дробной
            double length;
            // и денежная переменная для цены
            decimal finalPrice;
            // и строка, в которую мы будем читать пользовательский ввод
            string userInput = "";

            // итак, калькулятор работает пока пользователь не ввел 00
            while (userInput != "00")
            {
                // Информируем пользователя, что он должен ввести ширину
                Console.WriteLine("Enter width of the yard: ");
                // затем читаем ширину в строковую переменную
                userInput = Console.ReadLine();
                // а теперь конвертируем строку в дробь
                // 
                if (double.TryParse(userInput, out width))
                {
                    width = Convert.ToDouble(userInput);
                }
                else
                {
                    Console.WriteLine("Incorrect input, only numbers are allowed! Starting over...\n\n");
                    continue;
                }

                // Информируем пользователя, что он должен ввести длину
                Console.WriteLine("Enter length of the yard: ");
                // затем читаем ширину в строковую переменную
                userInput = Console.ReadLine();

                // а теперь конвертируем строку в дробь
                if (double.TryParse(userInput, out length))
                {
                    length = Convert.ToDouble(userInput);
                }
                else
                {
                    Console.WriteLine("Incorrect input, only numbers are allowed! Starting over...\n\n");
                    continue;
                }

                // Теперь мы вызываем функцию EstimateOrder (оценить заказ) и...
                // сохраняем результат в нашу переменную:
                finalPrice = PriceCalculator.EstimateOrder(width, length);
                // у нас есть цена и мы выводим ее на экран
                Console.WriteLine("Final price for your order: " + finalPrice + "$\n\n\n" ); 

            }

            Console.ReadKey();
        }

    }
}
