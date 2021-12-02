using System;

namespace LR3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте длину вектора А и В");
            int sizeA = Convert.ToInt32(Console.ReadLine());
            int sizeB = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[sizeA];
            int[] b = new int[sizeB];
            int[,] res = new int[sizeA, sizeB];
            int blokA=0, blokB = 0;

            Random rnd = new Random();
            for(int i =0; i < sizeA; i++)
            {
                a[i] = rnd.Next(-10,10);
                Console.Write(a[i] + " ");
                if ((i+1 > 1) &&(blokA==0)&& (sizeA % (i+1) == 0))
                {
                    blokA = i+1;
                }

            }
            Console.WriteLine();
            for (int i = 0; i < sizeB; i++)
            {
                b[i] = rnd.Next(-10, 10);
                Console.Write(b[i] + " ");
                if ((i+1 > 1)&&(blokB == 0) && (sizeB % (i+1) == 0))
                {
                    blokB = i+1;
                }
            }

            

            Console.WriteLine("\n");
            for (int ii = 0; ii < sizeA; ii += blokA)
            {
                for (int jj = 0; jj < sizeB; jj += blokB)
                {
                    for (int i = ii; i < ii + blokA; i++)
                    {
                        for (int j = jj; j < jj + blokB; j++)
                        {
                            res[i, j] = a[i] * b[j];
                            Console.Write(res[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("______________");
                }
                Console.WriteLine("\n************");
            }
            Console.ReadKey();
            //_______________________________
            ;
            Console.ReadKey();

            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
