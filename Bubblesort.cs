using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i=0; i < 5 ;i++)
            {
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Int Only");
                    Program.Main(args);
                }
            }

            for (int x=0; x<array.Length; x++)
            {
                for (int j=0; j<array.Length; j++)
                {
                    if (array[x]<array[j])
                    {
                        int bubble = array[x];
                        array[x] = array[j];
                        array[j] = bubble;
                    }
                }
            }
            Console.WriteLine(" ");
            for (int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]+" ");
            }

        }

        
    }
    
}
