using System;
using System.Collections.Generic;
using System.Text;


namespace WorkShop_Demo
{
    class ReverseString
    {
        public void RSt()
        {
            string str, revString = "";
            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();
            
            
            for(int i= str.Length-1 ; i>=0; i--)
            {
                revString = revString + str[i];

            }
            Console.WriteLine("Reverse String is: {0} ", revString);
           
        }
    }
}
