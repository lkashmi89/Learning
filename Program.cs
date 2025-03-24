using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, temp, sum = 0, rem;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Armstrong number.");
                Console.ReadLine();
            }

        }
    }
}
