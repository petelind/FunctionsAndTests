using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsAndTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndTests.Tests
{
    [TestClass()]
    public class PriceCalculatorTests
    {
        [TestMethod()]
        public void EstimateOrderTestWithCorrectNumbers()
        /// Этот тест проверяет, считает ли функция правильно для стандартного случая - без скидок и надбавок
        {
            // assign
            double width = 50;
            double length = 7.5;
            decimal expected = 7.5M * 50 * 5;
            // act
            decimal actual = PriceCalculator.EstimateOrder(width, length);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EstimateOrderWithWrongNumbers()
        /// Этот тест проверяет, вернем ли мы -1 получив 0 или отрицательное число на входе
        {
            // assign
            double width = 10;
            double length = -10;
            decimal expected = -1;
            // act
            decimal actual = PriceCalculator.EstimateOrder(width, length);
            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EstimateOrderWithPriceUptick ()
        /// Этот тест проверяет, делаем ли мы надбавку в 20% на заказах меньше 1000
        {
            // assign
            double width = 10;
            double length = 10;
            decimal expected = Convert.ToDecimal(width * length * 5 * 1.2);

            // act
            decimal actual = PriceCalculator.EstimateOrder(width, length);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EstimateOrderWithDiscount()
        /// а этот тест проверяет, делаем ли мы скидку для заказов больше 2500
        {
            // assign
            double width = 1000;
            double length = 1000;
            decimal expected = Convert.ToDecimal(width * length * 5 * 0.95);

            // act
            decimal actual = PriceCalculator.EstimateOrder(width, length);

            // assert
            Assert.AreEqual(expected, actual);
        }


    }
}