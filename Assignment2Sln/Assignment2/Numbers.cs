using System;

namespace Assignment2
{
    internal class Numbers
    {
        public static string ConvertNumtoWords(int num)
        {
            string[] units = { "Zero", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] doubleDigits = { "", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] tens = { " ", "Ten ", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string hundred = "hundred";
            string thousand = "thousand";

            Console.WriteLine("Enter a number from 0 to 9999");
            string number = Console.ReadLine();
            int convertedNumbers = Convert.ToInt32(number);
            string result = ConvertToWords(convertedNumbers);

            Console.WriteLine(result);
            return result;
        }

        private static string ConvertToWords(int convertedNumbers)
        {
            string[] units = { "Zero", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] doubleDigits = { "", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] tens = { " ", "Ten ", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };

            int n;
            if (convertedNumbers == 0)
            {
                return units[convertedNumbers];
            }
            else if (convertedNumbers <= 9)
            {
                return units[convertedNumbers];
            }
            else if (convertedNumbers <= 19)
            {
                return doubleDigits[convertedNumbers - 10];
            }
            else if (convertedNumbers <= 99)
            {
                return tens[(convertedNumbers / 10)] + units[(convertedNumbers % 10)];
            }
            else if (convertedNumbers <= 999)
            {
                return units[convertedNumbers / 100] + " Hundred and " + ConvertToWords(convertedNumbers % 100);
            }
            else if (convertedNumbers <= 9999)
            {
                string hundredsPart = (convertedNumbers % 1000 != 0) ? ConvertToWords(convertedNumbers % 1000) : " ";
                return units[convertedNumbers / 1000] + " Thousand " + hundredsPart;
            }
            return "";
        }
    }
}
