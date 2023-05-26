using Microsoft.Extensions.Logging;
using System;

namespace Task1.service.impl
{
    public static class StringService
    {
        // Task 4.1 Returns a reversed version of the input string.Do not use String.Reverse()
        public static string ReverseString(string s) {
            char[] chars = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                chars[i] = s[j];
                chars[j] = s[i];
            }
            return "Task 4.1 ReverseString: " + '\n' + "Original string: " + s + '\n' + "New string: " + new string(chars);
        }

        // Task 4.2 Checks the input string is a palindrome
        public static bool IsPalindrome(String s)
        {
            var middle = s.Length / 2;

            for (var i = 0; i <= middle; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
       
     
        // Task 4.3 find Missing Elements in the <int> array
        public static IEnumerable<int> MissingElements(this int[] arr) 
        {
                List<int> list = new List<int>();
                list.AddRange(arr);

                list.Sort();

                var firstNumber = list.First();

                var lastNumber = list.Last();

                // Range that contains all numbers in the interval
                var range = Enumerable.Range(firstNumber, lastNumber - firstNumber);

                // Getting the set difference
                var missingNumbers = range.Except(list);

                Console.Write("\nMissing Elements : ");
           
            if (missingNumbers == null || !missingNumbers.Any())
                {
                Console.WriteLine("[]");
                }
                
                return missingNumbers;
            }

    }
}

