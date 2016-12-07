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
            /// В ЭТОМ КОДЕ ЕСТЬ КРАЙНЕ НЕПРИЯТНЫЕ ОШИБКИ!!!
            /// Подумай, а) что за ошибки здесь есть и б) как их исправить?
            /// TODO: What are the errors in design & how to fix them?
            
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
                width = Convert.ToDouble(userInput);

                // Информируем пользователя, что он должен ввести ширину
                Console.WriteLine("Enter length of the yard: ");
                // затем читаем ширину в строковую переменную
                userInput = Console.ReadLine();
                // а теперь конвертируем строку в дробь
                length = Convert.ToDouble(userInput);

                // Теперь мы вызываем функцию EstimateOrder (оценить заказ) и...
                // сохраняем результат в нашу переменную:
                finalPrice = PriceCalculator.EstimateOrder(width, length);
                // у нас есть цена и мы выводим ее на экран
                Console.WriteLine("Final price for your order: " + finalPrice + "$\n\n\n" ); 

            }
        }

    }
}
