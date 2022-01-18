using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WorkShop_Demo
{
    class ReverseWordsInString
    {
        public void ReverseString()
        {
            Console.WriteLine("Enter String: ");
            string inputstring = Console.ReadLine();
            string resultString= string.Join(" ", inputstring.Split(" ").Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(resultString);
        }
    }
}
