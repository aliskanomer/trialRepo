
//Developed by Ömer Faruk Alışkan for Lunes Tech.

using System;

namespace assignment_1._1_to_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Developed by : Ömer Faruk Alışkan");
            Console.WriteLine("Hi!");
            Console.WriteLine("Assignment 1.1");

            Console.WriteLine("Assignment 1.2:");
            printAscending(1);

            Console.WriteLine("\nAssignment 1.3:");
            printDescending();

            //Assignment 1.4
            Console.Write("\n n = ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Assignment 1.4 \t -for loop \t : " + Sum1(val));

            //Assignment 1.5
            Console.WriteLine("Assignment 1.5 \t -while loop \t : " + Sum2(val));
            if (val >= 0)
            {
                Console.WriteLine("Assignment 1.5 \t -O(1) \t : " + Sum4(val,1));
            }
            else
            {
                Console.WriteLine("Assignment 1.5 \t -O(1) \t : " + Sum4(val,-1));
            }

            Console.ReadKey();
        }

        //Assignment 1.2
        public static void printAscending(int n)
        {
            if (n <= 100)
            {
                Console.Write(n + " ");
                printAscending(n + 1);
            }
        }

        //Assignment 1.3
        public static void printDescending()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
        }

        //Asignment 1.4
        public static int Sum1(int n)
        {
            int sum = 0;

            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for(int i = 1; i >= n; i--)
                {
                    sum += i;
                }
            }
            
            return sum;
        }

        //Assignment 1.5
        public static int Sum2(int n)
        {
            int i = 1, sum = 0;
            if (n >= 0)
            {
                while (i <= n)
                {
                    sum += i;
                    i++;
                }
            }
            else
            {
                while (i >= n)
                {
                    sum += i;
                    i--;
                }
            }
            
            return sum;
        }

        //Assignment 1.5.1
        public static int Sum4(int n,int x)
        {
            return n = (((n + 1) * ((n - 1) + x)) / (2 * x));
        }
    }
}
