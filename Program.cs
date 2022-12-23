using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, sum;
            Console.WriteLine(" Enter the first value : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last value : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect numbers are : ");
            for (n = x; n <= y; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
        }
    }
}
