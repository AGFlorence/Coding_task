using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bts_coachtasks
{
    class Program
    {
        /*
         @ function static void Main(string[] args)
         * this is the main function the handles the program's outputs
         */
        static void Main(string[] args)
        {
            Console.Write("1. output 'Hello World!'");
            Console.ReadLine();
            HW();
            Console.Write("2. output y=x^3");
            Console.ReadLine();
            OY(2);
            Console.Write("3. output Nth term increment by 1");
            Console.ReadLine();
            nINC(5);
            //arrayOfX(10);
            Console.Write("5. fizzbuzz sequence");
            Console.ReadLine();
            fizzBuzz(100);
            Console.Write("6. output the fibanacci sequence");
            Console.ReadLine();
            fibSeq(10);
        }

        //1. "output hello world!"
        public static void HW()
        {
            Console.Write("Hello World!");
            Console.ReadLine();
        }

        //2. output y = x ^ 3
        public static void OY(int x)
        {
            double y = Math.Pow(x,3);
            Console.Write("x ^ 3 = " + y);
            Console.ReadLine();
        }

        //3. output Nth term increment by 1
        public static void nINC(int n)
        {
            int term = 1;
            for (int i = 0; i < n;)
            {
                term = term + i;
                Console.Write(term + ",");
                i++;
            }
            Console.ReadLine();
        }

        //4. output array of no.s 1 - 10
        public static void arrayOfX(int x)
        {
            int[] array = new int[10];
        }

        //5. fizzbuzz sequence
        public static void fizzBuzz(int n)
        {
            for (int i = 1; i < n;)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("fizzbuzz,");
                    }
                    else if (i % 3 == 0 && i % 5 > 0)
                    {
                        Console.Write("buzz,");
                    }
                    else if (i % 5 == 0 && i % 3 > 0)
                    {
                        Console.Write("fizz,");
                    }                    
                }
                else
                {
                    Console.Write(i + ",");
                }
                i++;
            }
            Console.ReadLine();
        }

        //6. output the fibanacci sequence
        public static void fibSeq(int n)
        {
            const int a = 0;
            int b = 1;
            int c = 1;
            int d;
            Console.Write(a + ", " + b + ", " + c + ", ");
            n = n - 3;
            for (int i = 0; i < n;)
            {
                d = b + c;
                Console.Write(d + ", ");
                b = c;
                c = d;
                i++;
            }
            Console.ReadLine();
        }
    }
}
