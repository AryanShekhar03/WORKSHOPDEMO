using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop_Demo
{
    class ReverseNumbers
    {
        public void Reverse()
        {
            int num, reverse = 0, reminder;

            Console.Write("enter a number: ");

            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10; 
            }
            Console.Write("reversed rumber: " + reverse);

        }
    }
}
