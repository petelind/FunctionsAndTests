using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndTests
{
    public static class PriceCalculator
    /// Это по сути библиотека функций с одной функцией Estimate Order
    {
        // ключевое слово const позволяет объявить переменную, которая не будет меняться
        const decimal pricePerMeter = 5M;

        public static decimal EstimateOrder(double width, double length)
        /// Назначение: считает цену заказа с учетом скидок и надбавок.
        /// Вход: ширина и длина двора как double.
        /// Выход: цена заказа как decimal, -1 если значения неверные (0, негативные).
        {
            // нам понадобится переменная, содержащая деньги, для общей цены заказа
            decimal price;
            // но минуточку, мы получили на вход double, а все вычисления ведутся в decimal!
            // надо сконвертировать длину и ширину в decimal c помощью Сonvert.ToDecimal(имя_переменной);
            // сконвертируй ширину:
            decimal _width = Convert.ToDecimal(width);
            // сконвертируй длину:
            decimal _length = Convert.ToDecimal(length);
            // кстати, обрати внимание - для конверсии мы используем такой же статический класс :)

            // теперь мы можем посчитать цену... 
            price = _width * _length * pricePerMeter;
            Console.WriteLine("_________________________");
            Console.WriteLine("Base price for this order: " + price);

            // и если она меньше или равна нулю - мы возвращаем -1 (то есть ошибка)
            if (price <= 0)
                { return -1; }
            // а иначе проверяем коэффициенты:
            // если цена заказа менее 1000 - то надо сделать НАДбавку + 20% к цене
            // Напоминалка: при операциях с цифрами и decimal (например, при умножении)
            // надо использовать М в конце записи числа: decimal pi = 3.14M;
            if (price < 1000)
            {
                Console.WriteLine("Small order, so charging extra 20%: " + price * 0.2M + "$");
                price = price * 1.2M;
                Console.WriteLine("_________________________");

            }

            // а если цена заказа более 2500 - то надо сделать скидку 5% от цены
            if (price > 2500)
            {
                Console.WriteLine("Big order, so charging 5% less: -" + price * 0.05M + "$");
                price = price * 0.95M;
                Console.WriteLine("_________________________");
            }
            // и вернуть цену заказа тому, кто запросил

            return price;

        }
    }
}
