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

        public static bool IsPalRec(String s,
                             int first,
                             int last)
        {

            if (first == last)
                return true;

            if ((s[first]) != (s[last]))
                return false;

            if (first < last + 1)
                return IsPalRec(s, first + 1,
                                last - 1);
            return true;
        }

        // Task 4.2 Checks the input string is a palindrome
        public static bool IsPalindrome(String s)
        {
            int n = s.Length;

            if (n == 0)
                return true;

            return IsPalRec(s, 0, n - 1);
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

            return missingNumbers;
        }

    }
}

