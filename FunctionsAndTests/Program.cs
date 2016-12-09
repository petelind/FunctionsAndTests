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

            /// TODO: Как сделать чтоб программа завершалась по вводу 00? 
            
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
                if (double.TryParse(userInput, out width) && width > 0) // читается "получилось сделать цифру и она больше 0"...
                {
                    width = Convert.ToDouble(userInput); // строго говоря, TryParse уже произвел результат, но так наверное понятнее? :)
                }
                else
                {
                    Console.WriteLine("Incorrect input, only positive numbers are allowed! Starting over...\n\n");
                    continue;
                }


                // Информируем пользователя, что он должен ввести ширину
                Console.WriteLine("Enter length of the yard: ");
                // затем читаем ширину в строковую переменную
                userInput = Console.ReadLine();
                // а теперь конвертируем строку в дробь

                if (double.TryParse(userInput, out length) && length > 0)
                {
                    length = Convert.ToDouble(userInput);
                }
                else
                {
                    Console.WriteLine("Incorrect input, only positive numbers are allowed! Starting over...\n\n");
                    continue;
                }


                // Теперь мы вызываем функцию EstimateOrder (оценить заказ) и...
                // сохраняем результат в нашу переменную:
                finalPrice = PriceCalculator.EstimateOrder(width, length);

                // если вдруг мы таки получили -1, что сейчас невозможно, но вдруг?
                if (finalPrice <= 0)
                {
                    Console.WriteLine("Something went terribly wrong, try to start over!");
                    continue;
                }


                // у нас есть цена и мы выводим ее на экран
                Console.WriteLine("Final price for your order: " + finalPrice + "$\n\n\n" ); 

            }
            Console.ReadKey();
        }

    }
}
