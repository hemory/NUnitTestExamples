using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class Calculator
    {

        public int Add(int firstNumber, int secondNumber) // We take in two numbers
        {
            return firstNumber + secondNumber; //Thi method returns/spits out the result of adding those two numbers
        }

        //subtract
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Divide(int firstNumber, int secondNumber)
        {


            try
            {
                return firstNumber / secondNumber;
            }
            catch
            {
                throw new DivideByZeroException();
            }
        }

        public List<int> Add2ToEachNumberInList(List<int> numList)
        {
            for (int i = 0; i < numList.Count; i++)
            {
                numList[i] += 2;
            }

            return numList;
        }

        public bool NumbersAreEqual(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return true;
            }

            return false;

        }

        public string TurnNumberIntoString(int realNumber)
        {
            if (realNumber == 1)
            {
                return "one";
            }

            if (realNumber == 2)
            {
                return "two";
            }

            if (realNumber == 3)
            {
                return "three";
            }

            return "Number is not found";
        }

    }
}
