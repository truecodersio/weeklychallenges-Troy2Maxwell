using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool contains = false;
            for(int i = 0; i < vals.Length; i++)
            {   

                if (vals[i] == false)
                {
                    contains = true;
                }
            }

            return contains;
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool odd = false;
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }

            foreach (int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
                {
                    odd = true;
                }

            return odd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upHigh = false;
            bool downLow = false;
            bool isNum = false;
            bool tooSlow = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    upHigh = true;
                }
                if (char.IsLower(password[i]))
                {
                    downLow= true;
                }
                if (char.IsDigit(password[i]))
                {
                    isNum = true;
                }
            }
            if (upHigh && downLow && isNum == true)
            {
                tooSlow = true;
            }
            return tooSlow;
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val[0];
            return first;

        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal quotient = 0;
            if(divisor == 0)
            {
                return 0;
            }

            quotient = (dividend) / (divisor);

            return quotient;
        }

        public int LastMinusFirst(int[] nums)
        {

            int minuend = nums[nums.Length - 1];
            int subtrahend = nums[0];
            int difference = minuend - subtrahend;
            return difference;
        }

        public int[] GetOddsBelow100()
        {
            int num = 0;
            int odd = 0;
            List<int> odds = new List<int>();
            while(num < 100)
            {
                num++;
                odd = num;
                if (odd % 2 != 0)
                {
                    odds.Add(odd);
                }
            }
            int[] value = odds.ToArray();
            return value;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            string upperWord = "";
            for(int i = 0; i <words.Length; i++)
            {
                upperWord = words[i].ToUpper();
                words[i] = upperWord;
            }
        }
    }
}
