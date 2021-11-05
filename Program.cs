using System;

namespace insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Int only");
                    Program.Main(args);
                }
            }
            insertionSort(array);
            Console.WriteLine(" ");
            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void insertionSort(int[] array)
        {
            for (int i=1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j -= 1;
                    array[j + 1] = key;
                }
            }
        }
    }
}
