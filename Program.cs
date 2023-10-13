using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.check_if_a_number_is_a_palindrome
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            int num,rev,sum = 0,temp;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum*10) + rev;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine("Congratulations! The given number is a palindrome");
            else
                Console.WriteLine("The givem number is not a palindrome");

            Console.Read();

        }
    }
}
