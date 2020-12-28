using System;

namespace ArraysIArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 5 };
            int[] arr1 = new int[25];

            Console.WriteLine("The length of arr1 is " + arr1.Length);

            double[] doubArr = new double[10];
            for (int i = 0; i < 10; i++)
            {
                doubArr[i] = i;
            }

            int counter = 0;
            foreach (double k in doubArr)
            {
                Console.WriteLine("Element {0} = {1}", counter++, k);
            }

            int[,] arr2D = new int[5,2] {
                {1,2 },
                {5,3},
                {4,2 },
                {7,8 },
                {12,12 }
            };
            //Jagged Array
            int[][] jagArr = new int[3][];
            jagArr[0] = new int[5];
            jagArr[1] = new int[2];
            jagArr[2] = new int[2];

            jagArr[0] = new int[] { 2, 3, 5, 7, 11 };
            jagArr[1] = new int[] { 1, 12 };
            jagArr[2] = new int[] { 4, 5 };

            // alternative way:
            int[][] jagArr2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 12 },
                new int[] { 3, 5 }
            };
            Console.WriteLine("The value in the middle of the first entry is {0}", jagArr2[0][2]);

            for (int i = 0; i < jagArr2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jagArr2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jagArr2[i][j]);
                }
            }
        }
    }
}
