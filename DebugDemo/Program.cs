using System;

namespace DebugDemo
{
    class Program
    {
        /*
          static int Test(int a,int b)
          {
              int sum = a + b;
              Console.WriteLine("the sum of " + a +" and "+b+"?");
              return sum;
          }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            
            if (i % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            Console.WriteLine("end program");
            //int  rst=Test(2, 4);
            //Console.WriteLine("the sum is  "+rst);
        }

        }
    }
}
