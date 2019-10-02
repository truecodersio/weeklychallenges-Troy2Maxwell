using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
             int evenOdd = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                 if (numbers[i] % 2 == 0)
                 {
                    evenOdd += numbers[i];
                 }

                 if (numbers[i] % 2 != 0)
                 {
                     evenOdd -= numbers[i];
                 }
             }
            return evenOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int min = 0;
            if (str1.Length > min)
            {
                min = str1.Length;

                if (str2.Length < min)
                {
                    min = str2.Length;
                }
                if (str3.Length < min)
                {
                    min = str3.Length;
                }
                if (str4.Length < min)
                {
                    min = str4.Length;
                }
            }
            return min;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int min = Int32.MinValue;
            if( number1 > min)
            {
                min = number1;
                if (number2 < min)
                {
                    min = number2;
                }
                if(number3 < min)
                {
                    min = number3;
                }
                if(number4 < min)
                {
                    min = number4;
                }
            }
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool formTri = false;

            if ((sideLength1 + sideLength2) > sideLength3)
            {
                if ((sideLength1 + sideLength3) > sideLength2)
                {
                    if ((sideLength2 + sideLength3) > sideLength1)
                    {
                        formTri = true;
                    }
                }
            }
            return formTri;
        }

        public bool IsStringANumber(string input)
        {
            bool isNum = false;

            double num = 0;

            isNum = double.TryParse(input, out num);

            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int notNullCount = 0;
            bool majNull = false;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
                else
                {
                    notNullCount++;
                }
            }
            if(nullCount > notNullCount)
                {
                    majNull = true;
                }
            return majNull;
        }

        public double AverageEvens(int[] numbers)
        {
            double evenCount = 0;
            double num = 0;
            double avg = 0;
            if(numbers == null)
            {
                return avg;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                    num += numbers[i];
                    avg = (num / evenCount);
                }
            
            }
            return avg;
        }

        public int Factorial(int number)
        {
            int fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return fact;
        }
    }
}
