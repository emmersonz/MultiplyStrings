using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static class Solution
        {
            public static string Multiply(string num1, string num2)
            {
                Console.WriteLine($"decimal value: {5.0 / 10}");

                var num1Value = extractIntValue(num1);
                Console.WriteLine($"num 1 value: {num1Value}");

                var num2Value = extractIntValue(num2);
                Console.WriteLine($"num 2 value: {num2Value}");

                decimal intProduct = (decimal)num1Value * (decimal)num2Value;
                Console.WriteLine($"Int Product: {intProduct}");
                //return ("abc");
                return createStringValue(intProduct);

            }

            private static int extractIntValue(string num)
            {
                int numValue = 0;
                int numLength = num.Length;
                for (int a = 0; a < numLength; a++)
                {
                    int temp = (int)(num[a] - '0');
                    numValue = numValue * 10 + temp;
                }
                return numValue;
            }

            private static string createStringValue(decimal intNum)
            {
                if (intNum < 10)
                {
                    var result = (char)((int)'0' + (int)intNum);
                    return result.ToString();
                }
                char a = (char)((int)'0' + intNum % 10);
                return createStringValue(intNum / 10) + a.ToString();
            }
        }

    }
}
