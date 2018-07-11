using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloMath
{
    public class UnitTest
    {
        [Test]
        public void Sum_OnePlusTwo_ReturnsThree()
        {
            //StringCalculator calc = new StringCalculator();
            int expectedResult = 3;
            int result = MyMath.Sum(1, 2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(4, 2, 2)]
        [TestCase(2, 1, 1)]
        [TestCase(3, 1, 2)]
        public void Sum_TwoNumbers_ReturnsTotal(int expected, int inputLhs, int inputRhs)
        {
            //StringCalculator calc = new StringCalculator();
            int result = MyMath.Sum(inputLhs, inputRhs);

            Assert.AreEqual(expected, result);
        }



        }
    }
