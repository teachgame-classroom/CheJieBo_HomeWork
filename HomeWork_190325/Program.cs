using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_190325
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOne(1, 2, 3);
            QuestionOne(3, 2, 1);
            QuestionOne(2, 3, 1);
        }

        static void QuestionOne(int a, int b, int c)
        {
            int[] nums = new int[] { a, b, c };

            for(int i = 0; i < nums.Length; i++)
            {
                for(int t = i + 1;t < nums.Length; t++)
                {
                    if(nums[i] > nums[t])
                    {
                        Console.WriteLine("第{0}个位置是{1},第{2}个位置是{3},交换位置", i, nums[i], t, nums[t]);
                        Console.Read();
                        int temp = nums[i];
                        nums[i] = nums[t];
                        nums[t] = temp;

                        Console.WriteLine("交换完成：第{0}个位置是{1},第{2}个位置是{3}", i, nums[i], t, nums[t]);
                        Console.Read();
                    }
                }
            }

            //for(int i)
        }
    }
}
