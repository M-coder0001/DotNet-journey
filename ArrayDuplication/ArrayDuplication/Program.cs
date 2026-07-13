using System.Diagnostics;

namespace ArrayDuplication 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int i, j, nrow, ncol;
            Console.Write("Enter the number of row elements for array :");
            nrow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of column elements for array :");
            ncol = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < nrow; i++)
            {
                for (j = 0; j < ncol; j++)
                {
                    Console.Write("Element[{0}][{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < nrow; i++)
            {
                for (j = 0; j < ncol; j++)
                {
                    arr2[i, j] = arr1[j, i];
                }
            }
            Console.WriteLine("\n\n----------First Array----------");
            for (i = 0; i < nrow; i++)
            {
                for (j = 0; j < ncol; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n----------Second Array----------");
            for (i = 0; i < nrow; i++)
            {
                for (j = 0; j < ncol; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}