using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bts_coachtasks
{
    class Program
    {
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

        //2. output y=x^3
        public static void OY(int x)
        {
            double y = Math.Pow(x,3);
            Console.Write("x^3 = " + y);
            Console.ReadLine();
        }

        //3. output Nth term increment by 1
        public static void nINC(int n)
        {
            int i = 0;
            int term = 1;
            while (n > 0)
            {
                term = term + i;
                Console.Write(term + ",");
                i++;
                n--;
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
            int i = 1;
            while (n > 0)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("fizzbuzz,");
                    }
                    if (i % 3 == 0 && i % 5 > 0)
                    {
                        Console.Write("buzz,");
                    }
                    if (i % 5 == 0 && i % 3 > 0)
                    {
                        Console.Write("fizz,");
                    }                    
                }
                else
                {
                    Console.Write(i + ",");
                }
                i++;
                n--;
            }
            Console.ReadLine();
        }

        //6. output the fibanacci sequence
        public static void fibSeq(int n)
        {
            n = n - 1;
            int a = 0;
            int b = 1;
            int c = a + b;
            Console.Write(c + ",");
            while (n > 0)
            {
                c = a + b;
                Console.Write(c + ",");
                a = b;
                b = c;
                n--;
            }
            Console.ReadLine();
        }
    }
}
