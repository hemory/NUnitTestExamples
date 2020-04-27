using NUnit.Framework;
using System.Collections.Generic;

namespace CalculatorApp.UnitTests
{
    //Test Class

    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 1)]
        public void AddAlwaysReturnsExpectedResult(int numberOne, int numberTwo)
        {
            //Arrange
            Calculator calculatorUnderTest = new Calculator();

            //Act 
            int answer = calculatorUnderTest.Add(numberOne, numberTwo);
            int expected = numberOne + numberTwo;

            //Assert
            Assert.That(answer, Is.EqualTo(expected));
        }



        //Test for subtract method

        [Test]
        public void SubtractAlwaysReturnsExpectedResult()
        {
            //arrange
            Calculator calculatorUnderTest = new Calculator();

            //act
            int answer = calculatorUnderTest.Subtract(10, 5);

            //assert
            Assert.That(answer, Is.EqualTo(5));

        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 5)]
        public void DivideAlwaysReturnsExpectedResult(int firstNumber, int secondNumber)
        {
            //arrange
            Calculator calculatorUnderTest = new Calculator();

            //act
            double answer = calculatorUnderTest.Divide(firstNumber, secondNumber);
            double expected = firstNumber / secondNumber;

            //assert
            Assert.That(answer, Is.EqualTo(expected));
        }

        //[Test]
//        public void DivideWillReturnZeroIfSecondNumberIsZero()
//        {
//            //arrange
//            Calculator calculatorUnderTest = new Calculator();
//
//            //act
//            double answer = calculatorUnderTest.Divide(5, 0);
//
//            //assert
//            Assert.That(answer, Is.EqualTo(0));
//        }

        [Test]
        public void Add2ToEachNumberInListAlwaysReturnsExpectedResult()
        {
            //arrange - The setup
            Calculator calculatorUnderTest = new Calculator();
            List<int> theList = new List<int> { 2, 4 }; //The list I am going to use to test my method


            //act
            List<int> answer = calculatorUnderTest.Add2ToEachNumberInList(theList);
            List<int> expectedList = new List<int> { 4, 6 };

            //assert
            Assert.That(answer, Is.EqualTo(expectedList));
        }

        [Test]
        public void Divide_Always_ThrowsException()
        {
            Assert.Throws<System.DivideByZeroException>(
                () => new Calculator().Divide(2, 0));
        }

        [Test]
        public void NumbersAreEqualAlwaysReturnTrue()
        {
            //arrange
            Calculator calcUnderTest = new Calculator();

            //act
            bool answer = calcUnderTest.NumbersAreEqual(2, 2);

            //assert
            Assert.That(answer, Is.EqualTo(true));
        }

        [Test]
        public void NumbersAreEqualChecksForFalseValue()
        {
            //arrange
            Calculator calcUnderTest = new Calculator();

            //act
            bool answer = calcUnderTest.NumbersAreEqual(2, 1);

            //assert
            Assert.That(answer, Is.EqualTo(false));
        }

        [TestCase(3, 3)]
        [TestCase(5, 6)]
        public void NumberAreEqualAlwaysReturnExpectedResult(int numberOne, int numberTwo)
        {
            //arrange
            Calculator calcUnderTest = new Calculator();

            //act
            bool results = calcUnderTest.NumbersAreEqual(numberOne, numberTwo);

            //assert
            if (numberOne == numberTwo)
            {
                Assert.AreEqual(results, true);
            }
            else
            {
               Assert.AreEqual(results, false);
            }
        }

        [Test]
        public void TurnNumberIntoStringAlwaysReturnsExpectedValueForOne()
        {
            //arrange
            Calculator calcUnderTest = new Calculator();

            //act
            string answer = calcUnderTest.TurnNumberIntoString(1);

            //assert
            Assert.That(answer, Is.EqualTo("one"));
        }
    }
}
