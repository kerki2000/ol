using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    public struct NumArray
    {
        public static void FrequencyOfElement(int[] nums, int numslength)
        {
            bool[] counted = new bool[numslength];
           
            for (int i = 0; i < numslength; i++)
            {
                if (counted[i] == true)
                    continue;
                int count = 1;
                for (int j = i + 1; j < numslength; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counted[j] = true;
                        count++;
                    }
                }
                Console.WriteLine("Element of the array-{0} his frequency-{1}", nums[i], count);

            }
            Console.ReadKey();
        }

        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3, 3, 8, 5, 7, 8, 8, 9, 5 };
            FrequencyOfElement(nums, nums.Length);
        }
    }
}





