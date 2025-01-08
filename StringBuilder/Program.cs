// See https://aka.ms/new-console-template for more information
using System.Text;
using System;

namespace Solution

{

    class Program
    {
        static void Main(string[] args)
        {
            stringBuilderCheck("keksik");
            consecutiveOrNot();
            checkDuplicates();
            checkDate();
            pascalMode();
            checkVowels();
        }

        public static void stringBuilderCheck(string input)
        {
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Remove(0, 10)
                .Insert(0, new string('+', 10));

            Console.WriteLine(builder);
        }

        public static void consecutiveOrNot()
        {
            Console.WriteLine("Input a few numbers separated by a hyphen:");
            string input = Console.ReadLine();
            string[] separatedNumber = input.Split('-');
            List<bool> upOrDown = new List<bool>();
            for (int i = 1; i < separatedNumber.Length; i++)
            {
                int previousNumber = Convert.ToInt32(separatedNumber[i - 1]);
                int nextNumber = Convert.ToInt32(separatedNumber[i]);
                if (previousNumber < nextNumber)
                    upOrDown.Add(true);
                else upOrDown.Add(false);
            }
            if ((upOrDown.First() == true && upOrDown.Contains(false)) ||
                (upOrDown.First() == false && upOrDown.Contains(true)))
                Console.WriteLine("Non Consecutive");
            else
                Console.WriteLine("Consecutive");
        }

        public static void checkDuplicates()
        {
            Console.WriteLine("Input a few numbers separated by a hyphen:");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                Console.WriteLine("Empty input");
            else
            {
                string[] separatedNumber = input.Split('-');
                List<int> numbers = new List<int>();
                foreach (string number in separatedNumber)
                {
                    numbers.Add(int.Parse(number));
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    List<int> duplicates = numbers.FindAll(x => x == numbers[i]);
                    if (duplicates.Count > 1)
                        Console.WriteLine("Duplicates exist");
                    break;
                }
                Console.WriteLine("End");
            }
        }
        public static void checkDate()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
                Console.WriteLine("Empty input");
            else
            {
                try
                {
                    DateTime dateTime = Convert.ToDateTime(input);
                    Console.WriteLine("All is good");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect format");
                }

            }
        }

        public static void pascalMode()
        {
            Console.WriteLine("Input a few words about you:");
            string input = Console.ReadLine();
            input = input.ToUpper();
            string[] separatedWords = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in separatedWords)
            {
                string pascalMode = word[0] + (word.Substring(1, word.Length - 1)).ToLower();
                sb.Append(pascalMode);
            }
            Console.WriteLine(sb);
        }
        public static void checkVowels()
        {
            Console.WriteLine("Input a word:");
            string input = Console.ReadLine();
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            int vowelsAmount = 0;
            char[] inputArray = input.ToArray<char>();
            foreach (char characters in inputArray)
                foreach (char vowel in vowels)
                    if (vowel == characters)
                        vowelsAmount++;

            Console.WriteLine("Vowels amount = " + vowelsAmount);
        }
        }
}
