using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentPoints =  { 4, 5, 76, 23, 76, 89, 34, 65, 78 };

            int point1 = studentPoints[3];

            int lastPoint = studentPoints[studentPoints.Length - 1];

            int[] numbers = new int[10];

            numbers[4] = 55;
            numbers[4] = -110;

            Console.WriteLine(numbers[4]);

            for (int i = 0; i < studentPoints.Length; i++)
            {
                if (studentPoints[i] % 2 == 0)
                {
                    Console.WriteLine(studentPoints[i]);
                }
            }

            int index = 0;
            while (index < studentPoints.Length)
            {
                Console.WriteLine(studentPoints[index]);
                index++;
            }


            string[] names = { "Abbas", "Hiket", "Tofiq", "Aygun" };

            for (int i = names.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(names[i]);
            }


            Console.WriteLine("=================================");

            var nums = new int[]{ 45, 10, -34, -45, 15 };
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    sum += nums[i];
                }
            }

            Console.WriteLine(sum);


            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * 10;
            }



        }
    }
}
