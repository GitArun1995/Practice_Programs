using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
            LargestNumber();
            VowelsCount();
            if (Palindrome())
                Console.WriteLine("String is palindrome");
            else
                Console.WriteLine("String is not a palindrome");
            Console.WriteLine($"Even numbers count {CountEvenNUmbers()}");

            Console.WriteLine($"Sum numbers count {sumOfNumbers()}");
            Console.ReadLine();
        }

        //Reverse of a string
        public static void ReverseString()
        {
            string str = "Hello";
            Console.WriteLine("Reverse of a string");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        //Largest of a number
        public static void LargestNumber()
        {
            Console.WriteLine("Largest number in an array");
            int[] arr = { 3, 7, 2, 9, 5 };
            int large = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }
            }
            Console.WriteLine($"Largest number in an array is { large}");

            Console.WriteLine();
            Console.WriteLine();
        }

        //Number of Vowels 
        public static void VowelsCount()
        {
            Console.WriteLine($"Count Vowels");
            string strr = "ProgrAmming";
            strr = strr.ToLower();
            int count = 0;
            for (int i = 0; i < strr.Length; i++)
            {
                if (strr[i] == 'a' || strr[i] == 'e' || strr[i] == 'i' || strr[i] == 'o' || strr[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine($"vowels count = { count}");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool Palindrome()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Palindrome or not");
            string str = "a";
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        public static int CountEvenNUmbers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Even numbers count");
            int[] numbers = { 1, 2, 3, 4, 6 };
            int count = 0;
            return  count = numbers.Count(x => x % 2 == 0);
        }

        public static int sumOfNumbers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("sum of numbers");
            int[] numbers = { 1, 2, 3, 4, 6 };
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                count += numbers[i];
            }
            return count;
        }
         public static void Multiplication()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
                for(int i=1;i<=a;i++){
                    for(int j=1;j<=b;j++){
                        Console.WriteLine($"{i} X {j} = {i*j}");
                    }
            Console.WriteLine();
            }
        }
    }
}
