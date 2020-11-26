using System;
using System.Threading;
namespace threadsWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0, max=0, mid=0;
            Thread myThread = new Thread(new ThreadStart(Count));
            Random rnd = new Random();
            for (int i = 1; i < 10000; i++)
            {
                int value = rnd.Next();
                if (min > value)
                {
                    min = value;
                }
                if (max < value)
                {
                    max = value;
                }
                mid = max / 10000;
            }
            Console.WriteLine("min = " + min + "\n");
            Console.WriteLine("max = " + max + "\n");
            Console.WriteLine("mid = " + mid + "\n");
        }
            public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}
