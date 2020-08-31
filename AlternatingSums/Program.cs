using System;

namespace AlternatingSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the row length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter an element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Alternating Sums are ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(alternatingSums(array)[i] + " "); 
            }
            Console.ReadLine();
        }
        static int[] alternatingSums(int[] a)
        {
            int[] res = new int[2];
            int first = 0;
            int second = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(i % 2 == 0)
                {
                    first += a[i];
                }
                else
                {
                    second += a[i];
                }
            }
            res[0] = first;
            res[1] = second;
            return res;
        }
    }
}
