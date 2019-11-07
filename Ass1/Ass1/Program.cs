using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program  to print all unique elements in an array
            int[] num = { 2, 2, 2, 5, 8, 9, 6, 4, 4, 8, 7, 6, 6 };
            UniqueElements(num);
        }
        public static void UniqueElements(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;

                }
                if (count < 2)
                    Console.Write(numbers[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
