using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumandmaximum
{
    class Program
    {

        //Write a program that takes input array daily temperatures and find the maximum and minimum values.

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Enter 10 numbers and I will find the highest and lowest numbers entered: ");

            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = array[0];
            for (int i=0; i<10; i++)
            {
                if(array[i]<smallest)
                {
                    smallest = array[i];
                }
            }

            int largest = array[9];
            for (int i=0; i<10; i++)
            {
                if(array[i]>largest)
                {
                    largest = array[i];
                }
            }
            Console.WriteLine("The smallest number entered is {0}", smallest);
            Console.WriteLine("The largest number entered is {0}", largest);
            Console.Read();
        }
    }
}
